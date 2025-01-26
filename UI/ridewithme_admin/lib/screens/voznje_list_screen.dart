import 'dart:ui';

import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_admin/models/grad.dart';
import 'package:ridewithme_admin/models/search_result.dart';
import 'package:ridewithme_admin/models/voznja.dart';
import 'package:ridewithme_admin/providers/gradovi_provider.dart';
import 'package:ridewithme_admin/providers/voznje_provider.dart';
import 'package:ridewithme_admin/screens/voznje_details_screen.dart';
import 'package:ridewithme_admin/widgets/custom_button_widget.dart';
import 'package:ridewithme_admin/widgets/master_screen.dart';

class VoznjeListScreen extends StatefulWidget {
  const VoznjeListScreen({super.key});

  @override
  State<VoznjeListScreen> createState() => _VoznjeListScreenState();
}

class _VoznjeListScreenState extends State<VoznjeListScreen> {
  late VoznjeProvider _voznjeProvider;
  late GradoviProvider _gradoviProvider;

  SearchResult<Voznja>? result;
  SearchResult<Gradovi>? gradoviResult;

  bool sortingControllVisible = false;
  String? _selectedValue;
  String? _selectedDirectionValue = 'ASC';

  bool isLoading = true;

  final _formKey = GlobalKey<FormBuilderState>();

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _voznjeProvider = context.read<VoznjeProvider>();
    _gradoviProvider = context.read<GradoviProvider>();

    initTable();
  }

  Future initTable() async {
    result = await _voznjeProvider
        .get(filter: {'IsGradoviIncluded': true, 'IsKorisniciIncluded': true});
    gradoviResult =
        await _gradoviProvider.get(filter: {'IsGradoviIncluded': true});

    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
        selectedIndex: 3,
        headerTitle: "Vožnje",
        headerDescription: "Ovdje možete pronaći listu vožnji.",
        child: Container(
          child: Column(
            children: [
              isLoading ? CircularProgressIndicator() : _buildSearch(),
              isLoading ? CircularProgressIndicator() : _buildResultView()
            ],
          ),
        ));
  }

  TextEditingController _sortingController = TextEditingController();
  Widget _buildSearch() {
    return FormBuilder(
      key: _formKey,
      child: Padding(
          padding: EdgeInsets.only(bottom: 20),
          child: Row(
            spacing: 10,
            children: [
              Expanded(
                  child: FormBuilderDropdown(
                name: "gradOdId",
                decoration: InputDecoration(
                  border: OutlineInputBorder(),
                  contentPadding: EdgeInsets.only(left: 5),
                  labelText: 'Grad od',
                  suffix: IconButton(
                    icon: const Icon(Icons.close),
                    onPressed: () {
                      _formKey.currentState!.fields['gradOdId']?.reset();
                    },
                  ),
                  hintText: 'Odaberi grad',
                ),
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
                  flex: 1,
                  child: FormBuilderDropdown(
                    name: "gradDoId",
                    decoration: InputDecoration(
                      contentPadding: EdgeInsets.only(left: 5),
                      border: OutlineInputBorder(),
                      labelText: 'Grad do',
                      suffix: IconButton(
                        icon: const Icon(Icons.close),
                        onPressed: () {
                          _formKey.currentState!.fields['gradDoId']?.reset();
                        },
                      ),
                      hintText: 'Odaberi grad',
                    ),
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
              DropdownMenu<String>(
                dropdownMenuEntries: const [
                  DropdownMenuEntry(value: "Id", label: "ID"),
                  DropdownMenuEntry(
                      value: "DatumVrijemePocetka", label: "Datum početka"),
                  DropdownMenuEntry(
                      value: "DatumVrijemeZavrsetka", label: "Datum završetka"),
                  DropdownMenuEntry(value: "Cijena", label: "Cijena"),
                ],
                selectedTrailingIcon: GestureDetector(
                  onTap: () {
                    setState(() {
                      _selectedValue = null;
                      _sortingController.clear();
                      _selectedDirectionValue = "ASC";
                      sortingControllVisible = false;
                    });
                  },
                  child: _selectedValue != null
                      ? Icon(Icons.clear)
                      : Icon(Icons.arrow_drop_down),
                ),
                label: const Text("Sortiraj"),
                controller: _sortingController,
                onSelected: (value) {
                  setState(() {
                    _selectedValue = value;
                    sortingControllVisible = true;
                  });
                },
              ),
              if (sortingControllVisible == true)
                DropdownMenu(
                  dropdownMenuEntries: [
                    DropdownMenuEntry(value: "ASC", label: "Rastuće"),
                    DropdownMenuEntry(value: "DESC", label: "Opadajuće"),
                  ],
                  onSelected: (value) {
                    setState(() {
                      _selectedDirectionValue = value;
                    });
                  },
                  initialSelection: 'ASC',
                  label: Text("Smijer"),
                ),
              Container(
                  width: 100,
                  height: 45,
                  child: CustomButtonWidget(
                      buttonText: "Pretraži",
                      onPress: () async {
                        //TODO: add call to api

                        _formKey.currentState?.save();

                        var filters = {};

                        filters['IsGradoviIncluded'] = true;
                        filters['IsKorisniciIncluded'] = true;

                        if (_formKey.currentState?.value['gradOdId'] != null) {
                          filters['GradOdId'] =
                              _formKey.currentState?.value['gradOdId'];
                        }

                        if (_formKey.currentState?.value['gradDoId'] != null) {
                          filters['GradDoId'] =
                              _formKey.currentState?.value['gradDoId'];
                        }

                        if (_selectedValue != null &&
                            _selectedDirectionValue != null) {
                          filters['OrderBy'] =
                              "$_selectedValue $_selectedDirectionValue";
                        }

                        print(filters);

                        result = await _voznjeProvider.get(filter: filters);

                        setState(() {});
                      })),
              Container(
                  width: 100,
                  height: 45,
                  child: CustomButtonWidget(
                      buttonText: "Dodaj",
                      onPress: () {
                        //TODO: add call to api

                        Navigator.of(context).push(
                          MaterialPageRoute(
                            builder: (context) => VoznjeDetailsScreen(),
                          ),
                        );
                      })),
            ],
          )),
    );
  }

  Widget _buildResultView() {
    return Expanded(
      child: SizedBox(
        width: double.infinity, // Expands to full width
        child: Container(
          decoration: BoxDecoration(
            borderRadius: BorderRadius.circular(20),
            color: Color(0x29C3CBCA),
            border: Border.all(color: Color(0xFFD3D3D3)),
          ),
          child: SingleChildScrollView(
            child: DataTable(
              showCheckboxColumn: false,
              columnSpacing: 25,
              border: const TableBorder(
                horizontalInside: BorderSide(
                  width: 1,
                  color: Color(0xFFD3D3D3),
                ),
              ),
              columns: [
                DataColumn(
                  label: Text(
                    "ID",
                    style: TextStyle(
                      color: Color(0xFF5A605F),
                      fontFamily: "Inter",
                      fontSize: 12,
                    ),
                  ),
                  numeric: true,
                ),
                DataColumn(
                  label: Text(
                    "Grad od",
                    style: TextStyle(
                      color: Color(0xFF5A605F),
                      fontFamily: "Inter",
                      fontSize: 12,
                    ),
                  ),
                ),
                DataColumn(
                  label: Text(
                    "Grad do",
                    style: TextStyle(
                      color: Color(0xFF5A605F),
                      fontFamily: "Inter",
                      fontSize: 12,
                    ),
                  ),
                ),
                DataColumn(
                  label: Text(
                    "Vozač",
                    style: TextStyle(
                      color: Color(0xFF5A605F),
                      fontFamily: "Inter",
                      fontSize: 12,
                    ),
                  ),
                ),
                DataColumn(
                  label: Text(
                    "Klijent",
                    style: TextStyle(
                      color: Color(0xFF5A605F),
                      fontFamily: "Inter",
                      fontSize: 12,
                    ),
                  ),
                ),
                DataColumn(
                  label: Text(
                    "Status",
                    style: TextStyle(
                      color: Color(0xFF5A605F),
                      fontFamily: "Inter",
                      fontSize: 12,
                    ),
                  ),
                ),
                DataColumn(
                  label: Text(
                    "Početak",
                    style: TextStyle(
                      color: Color(0xFF5A605F),
                      fontFamily: "Inter",
                      fontSize: 12,
                    ),
                  ),
                ),
                DataColumn(
                  label: Text(
                    "Završetak",
                    style: TextStyle(
                      color: Color(0xFF5A605F),
                      fontFamily: "Inter",
                      fontSize: 12,
                    ),
                  ),
                ),
                DataColumn(
                  numeric: true,
                  label: Text(
                    "Cijena",
                    style: TextStyle(
                      color: Color(0xFF5A605F),
                      fontFamily: "Inter",
                      fontSize: 12,
                    ),
                  ),
                ),
                DataColumn(
                  numeric: true,
                  label: SizedBox(width: 10),
                ),
              ],
              rows: result?.result
                      .map(
                        (e) => DataRow(
                          onSelectChanged: (value) {
                            if (value == true) {
                              Navigator.of(context).push(
                                MaterialPageRoute(
                                  builder: (context) =>
                                      VoznjeDetailsScreen(voznja: e),
                                ),
                              );
                            }
                          },
                          cells: [
                            DataCell(Text(
                              e.id.toString(),
                              style: TextStyle(
                                color: Color(0xFF072220),
                                fontFamily: "Inter",
                                fontSize: 12,
                              ),
                            )),
                            DataCell(Text(
                              e.gradOd?.naziv ?? "",
                              style: TextStyle(
                                color: Color(0xFF072220),
                                fontFamily: "Inter",
                                fontSize: 12,
                              ),
                            )),
                            DataCell(Text(
                              e.gradDo?.naziv ?? "",
                              style: TextStyle(
                                color: Color(0xFF072220),
                                fontFamily: "Inter",
                                fontSize: 12,
                              ),
                            )),
                            DataCell(Text(
                              "${e.vozac?.ime} ${e.vozac?.prezime}" ?? "",
                              style: TextStyle(
                                color: Color(0xFF072220),
                                fontFamily: "Inter",
                                fontSize: 12,
                              ),
                            )),
                            DataCell(Text(
                              e.klijent != null
                                  ? "${e.klijent?.ime} ${e.klijent?.prezime}"
                                  : "N/A",
                              style: TextStyle(
                                color: Color(0xFF072220),
                                fontFamily: "Inter",
                                fontSize: 12,
                              ),
                            )),
                            DataCell(Badge(
                              label: Text(e.stateMachine?.toLowerCase() ?? ""),
                              backgroundColor: e.stateMachine == "draft"
                                  ? Colors.amber
                                  : e.stateMachine == "active"
                                      ? Colors.green
                                      : Colors.red,
                            )),
                            DataCell(Text(
                              e.datumVrijemePocetka?.toString() ?? "N/A",
                              style: TextStyle(
                                color: Color(0xFF072220),
                                fontFamily: "Inter",
                                fontSize: 12,
                              ),
                            )),
                            DataCell(Text(
                              e.datumVrijemeZavrsetka?.toString() ?? "N/A",
                              style: TextStyle(
                                color: Color(0xFF072220),
                                fontFamily: "Inter",
                                fontSize: 12,
                              ),
                            )),
                            DataCell(Text(
                              e.cijena.toString() + " KM",
                              style: TextStyle(
                                color: Color(0xFF072220),
                                fontFamily: "Inter",
                                fontSize: 12,
                              ),
                            )),
                            DataCell(Row(
                              children: [
                                IconButton(
                                  iconSize: 17,
                                  onPressed: () {},
                                  icon: Icon(Icons.delete),
                                ),
                                IconButton(
                                  onPressed: () {},
                                  icon: Icon(Icons.edit),
                                  iconSize: 17,
                                ),
                              ],
                            )),
                          ],
                        ),
                      )
                      .toList()
                      .cast<DataRow>() ??
                  [],
            ),
          ),
        ),
      ),
    );
  }
}
