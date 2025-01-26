import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_admin/models/grad.dart';
import 'package:ridewithme_admin/models/voznja.dart';
import 'package:ridewithme_admin/providers/gradovi_provider.dart';
import 'package:ridewithme_admin/providers/voznje_provider.dart';
import 'package:ridewithme_admin/widgets/custom_button_widget.dart';
import 'package:ridewithme_admin/widgets/master_screen.dart';
import '../models/search_result.dart';

class VoznjeDetailsScreen extends StatefulWidget {
  Voznja? voznja;
  VoznjeDetailsScreen({super.key, this.voznja});

  @override
  State<VoznjeDetailsScreen> createState() => _VoznjeDetailsScreenState();
}

class _VoznjeDetailsScreenState extends State<VoznjeDetailsScreen> {
  late VoznjeProvider _voznjeProvider;
  late GradoviProvider _gradoviProvider;

  SearchResult<Gradovi>? gradoviResult;

  final _formKey = GlobalKey<FormBuilderState>();
  Map<String, dynamic> _initialValue = {};

  bool isLoading = true;

  @override
  void initState() {
    _voznjeProvider = context.read<VoznjeProvider>();
    _gradoviProvider = context.read<GradoviProvider>();
    // TODO: implement initState
    super.initState();

    _initialValue = {
      'napomena': widget.voznja?.napomena,
      'cijena': widget.voznja?.cijena.toString(),
      'gradOdId': widget.voznja?.gradOd?.id,
      'gradDoId': widget.voznja?.gradDo?.id,
    };

    initForm();
  }

  Future initForm() async {
    gradoviResult = await _gradoviProvider.get();

    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      selectedIndex: 3,
      headerTitle: _initialValue != {} ? "Detalji vožnje" : "Kreiranje vožnje",
      headerDescription: "Ovdje možete pogledati detalje o vožnji.",
      child: Column(
        children: [isLoading ? Container() : _buildForm(), _save()],
      ),
    );
  }

  Widget _buildForm() {
    return FormBuilder(
        key: _formKey,
        initialValue: _initialValue,
        child: Column(
          children: [
            Row(
              children: [
                Expanded(
                    child: FormBuilderTextField(
                  name: "cijena",
                  initialValue: _initialValue['cijena'].toString(),
                  decoration: InputDecoration(label: Text("Cijena")),
                )),
                SizedBox(
                  width: 10,
                ),
                Expanded(
                    child: FormBuilderTextField(
                  name: "napomena",
                  initialValue: _initialValue['napomena'],
                  decoration: InputDecoration(label: Text("Napomena")),
                ))
              ],
            ),
            Row(
              children: [
                Expanded(
                    child: FormBuilderDropdown(
                  name: "gradOdId",
                  decoration: InputDecoration(label: Text("Grad od")),
                  initialValue:
                      _initialValue['gradOdId'] ?? gradoviResult?.result[0].id,
                  items: gradoviResult?.result
                          .map((e) => DropdownMenuItem(
                                value: e.id,
                                child: Text(
                                  e.naziv ?? "",
                                  style: TextStyle(color: Colors.black),
                                ),
                              ))
                          .toList() ??
                      [],
                )),
                Expanded(
                    child: FormBuilderDropdown(
                  name: "gradDoId",
                  initialValue:
                      _initialValue['gradDoId'] ?? gradoviResult?.result[1].id,
                  decoration: InputDecoration(label: Text("Grad do")),
                  items: gradoviResult?.result
                          .map((e) => DropdownMenuItem(
                                value: e.id,
                                child: Text(
                                  e.naziv ?? "",
                                  style: TextStyle(color: Colors.black),
                                ),
                              ))
                          .toList() ??
                      [],
                )),
              ],
            )
          ],
        ));
  }

  Widget _save() {
    return Padding(
      padding: const EdgeInsets.all(8.0),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.end,
        children: [
          Container(
              width: 100,
              height: 45,
              child: CustomButtonWidget(
                  buttonText: "Sačuvaj",
                  onPress: () {
                    _formKey.currentState?.saveAndValidate();
                    debugPrint(_formKey.currentState?.value.toString());

                    if (widget.voznja == null) {
                      _voznjeProvider.insert(_formKey.currentState?.value);

                      showDialog(
                        context: context,
                        builder: (context) {
                          return SimpleDialog(
                            title: Row(
                              children: [
                                Icon(Icons.info),
                                SizedBox(
                                  width: 10,
                                ),
                                Text(
                                  "Uspješno ste kreirali novu vožnju",
                                  style: TextStyle(
                                      fontFamily: "Inter",
                                      fontWeight: FontWeight.bold),
                                )
                              ],
                            ),
                            contentPadding: EdgeInsets.all(10),
                            children: [
                              Text(
                                "Vožnja koju ste kreirali je kreirana putem Administratorskog naloga.",
                                style: TextStyle(
                                    fontFamily: "Inter",
                                    fontWeight: FontWeight.w500),
                              )
                            ],
                          );
                        },
                      );
                    } else {
                      _voznjeProvider.update(
                          widget.voznja!.id!, _formKey.currentState?.value);
                    }
                  })),
        ],
      ),
    );
  }
}
