import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_admin/models/recenzija.dart';
import 'package:ridewithme_admin/models/search_result.dart';
import 'package:ridewithme_admin/providers/recenzije_provider.dart';
import 'package:ridewithme_admin/screens/kuponi_details_screen.dart';
import 'package:ridewithme_admin/screens/ocjene_details_screen.dart';
import 'package:ridewithme_admin/utils/input_utils.dart';
import 'package:ridewithme_admin/utils/table_utils.dart';
import 'package:ridewithme_admin/widgets/loading_spinner_widget.dart';
import 'package:ridewithme_admin/widgets/master_screen.dart';

class OcjeneScreen extends StatefulWidget {
  const OcjeneScreen({super.key});

  @override
  State<OcjeneScreen> createState() => _OcjeneScreenState();
}

class _OcjeneScreenState extends State<OcjeneScreen> {
  late RecenzijeProvider _recenzijeProvider;

  final _formKey = GlobalKey<FormBuilderState>();

  SearchResult<Recenzija>? recenzijaResult;

  bool isLoading = true;

  Map<String, dynamic> _initialValue = {};

  final _horizontalScrollController = ScrollController();

  final List<Map<String, dynamic>> columnData = [
    {"label": "ID", "numeric": true},
    {"label": "Vožnja ID", "numeric": true},
    {"label": "Klijent ime"},
    {"label": "Vozač ime"},
    {"label": "Ocjena", "numeric": true},
    {"label": "Datum ostavljanja ocjene"},
    {"label": "", "numeric": true}, // Prazna kolona za dugmad
  ];

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _recenzijeProvider = context.read<RecenzijeProvider>();

    _initialValue = {
      'OrderBy': 'id ASC',
      'KorisnikGTE': null,
      'VoznjaId': null
    };

    initTable();
  }

  Future initTable() async {
    String orderByField = _formKey.currentState?.value['OrderByField'] ?? "id";
    String orderByDirection =
        _formKey.currentState?.value['OrderByDirection'] ?? "ASC";

    recenzijaResult = await _recenzijeProvider.get(filter: {
      'OrderBy': "$orderByField $orderByDirection",
      'KorisnikGTE': _formKey.currentState?.value['KorisnikGTE'],
      'VoznjaId': _formKey.currentState?.value['VoznjaId']
    });

    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      selectedIndex: 12,
      headerTitle: "Ocjene",
      headerDescription:
          "Ovdje možete pregledati ocjene koje su korisnici ostavili vozačima",
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          _buildSearch(),
          isLoading ? LoadingSpinnerWidget() : _buildResultView()
        ],
      ),
    );
  }

  Widget _buildSearch() {
    return FormBuilder(
      key: _formKey,
      onChanged: () {
        _formKey.currentState?.save();
        initTable();
      },
      child: Padding(
        padding: const EdgeInsets.only(bottom: 20),
        child: SizedBox(
          width: MediaQuery.of(context).size.width / 3,
          child: Row(
            spacing: 10,
            children: [
              Expanded(
                  child: FormBuilderTextField(
                name: "KorisnikGTE",
                decoration: buildTextFieldDecoration(
                    hintText: "Korisničko ime...",
                    labelText: "Korisničko ime",
                    prefixIcon: Icon(Icons.abc_rounded)),
              )),
              Expanded(
                  child: FormBuilderTextField(
                name: "VoznjaId",
                keyboardType: TextInputType.number,
                valueTransformer: (value) {
                  if (value != null) {
                    return int.tryParse(value);
                  }
                },
                validator: FormBuilderValidators.compose([
                  FormBuilderValidators.float(
                    errorText: 'Ovo polje mora biti broj.',
                  ),
                ]),
                initialValue: _initialValue['VoznjaId'],
                decoration: buildTextFieldDecoration(
                    hintText: "Voznja ID...",
                    labelText: "Voznja ID",
                    prefixIcon: Icon(Icons.numbers_rounded)),
              )),
              Expanded(
                child: buildDropdown(
                  name: "OrderByField",
                  labelText: "Sortiraj po",
                  initialValue: "id",
                  prefixIcon: Icon(Icons.sort_by_alpha_rounded),
                  items: const [
                    DropdownMenuItem(value: "id", child: Text("ID")),
                    DropdownMenuItem(value: "Ocjena", child: Text("Ocjena")),
                    DropdownMenuItem(
                        value: "DatumKreiranja",
                        child: Text("Datum ostavljanja ocjene")),
                  ],
                ),
              ),
              Expanded(
                child: buildDropdown(
                  name: "OrderByDirection",
                  labelText: "Smjer",
                  initialValue: "ASC",
                  prefixIcon:
                      _formKey.currentState?.value['OrderByDirection'] == "ASC"
                          ? Icon(Icons.arrow_upward_rounded)
                          : Icon(Icons.arrow_downward_rounded),
                  items: const [
                    DropdownMenuItem(value: "ASC", child: Text("Rastuće")),
                    DropdownMenuItem(value: "DESC", child: Text("Opadajuće")),
                  ],
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }

  DataRow _buildDataRow(Recenzija e, BuildContext context) {
    return DataRow(
      cells: [
        buildDataCell(e.id?.toString()),
        buildDataCell(e.voznja?.id?.toString()),
        buildDataCell(e.korisnik?.korisnickoIme),
        buildDataCell(e.voznja?.vozac?.korisnickoIme),
        buildDataCell(e.ocjena.toString()),
        buildDataCell(e.datumKreiranja != null
            ? DateFormat('dd/MM/yyyy hh:mm').format(e.datumKreiranja!)
            : "N/A"),
        DataCell(Row(
          children: [
            IconButton(
              onPressed: () {
                Navigator.of(context)
                    .push(
                      MaterialPageRoute(
                        builder: (context) => OcjeneDetailsScreen(
                          recenzija: e,
                        ),
                      ),
                    )
                    .then((value) => setState(() {}));
              },
              icon: const Icon(Icons.edit),
              iconSize: 17,
            ),
          ],
        )),
      ],
    );
  }

  Widget _buildResultView() {
    if (isLoading == false &&
        recenzijaResult != null &&
        recenzijaResult?.count == 0) {
      return Text("Nema rezultata.");
    }

    return Expanded(
      child: SingleChildScrollView(
        child: Column(
          children: [
            Container(
              decoration: BoxDecoration(
                color: Color(0x29C3CBCA),
                borderRadius: BorderRadius.circular(20),
                border: Border.all(color: Color(0xFFD3D3D3)),
              ),
              child: Padding(
                padding: const EdgeInsets.all(8.0),
                child: Scrollbar(
                  controller: _horizontalScrollController,
                  thumbVisibility: true,
                  trackVisibility: true,
                  child: SingleChildScrollView(
                    controller: _horizontalScrollController,
                    scrollDirection: Axis.horizontal,
                    child: ConstrainedBox(
                      constraints: BoxConstraints(
                          maxWidth: 700,
                          minWidth: 700,
                          minHeight: MediaQuery.of(context).size.height - 250),
                      child: DataTable(
                        showCheckboxColumn: false,
                        columnSpacing: 25,
                        columns: columnData.map((col) {
                          return DataColumn(
                            label: Text(col["label"], style: columnTextStyle),
                            numeric: col["numeric"] ?? false,
                          );
                        }).toList(),
                        rows: recenzijaResult?.result
                                .map((e) => _buildDataRow(e, context))
                                .toList()
                                .cast<DataRow>() ??
                            [],
                      ),
                    ),
                  ),
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}
