import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_admin/models/kupon.dart';
import 'package:ridewithme_admin/models/search_result.dart';
import 'package:ridewithme_admin/providers/kuponi_provider.dart';
import 'package:ridewithme_admin/screens/obavjestenja_details_screen.dart';
import 'package:ridewithme_admin/utils/input_utils.dart';
import 'package:ridewithme_admin/utils/table_utils.dart';
import 'package:ridewithme_admin/utils/util.dart';
import 'package:ridewithme_admin/widgets/custom_button_widget.dart';
import 'package:ridewithme_admin/widgets/loading_spinner_widget.dart';
import 'package:ridewithme_admin/widgets/master_screen.dart';

class KuponiScreen extends StatefulWidget {
  const KuponiScreen({super.key});

  @override
  State<KuponiScreen> createState() => _KuponiScreenState();
}

class _KuponiScreenState extends State<KuponiScreen> {
  late KuponiProvider _kuponiProvider;

  SearchResult<Kupon>? kuponiResult;

  final _formKey = GlobalKey<FormBuilderState>();

  Map<String, dynamic> _initialValue = {};

  bool isLoading = false;

  final List<Map<String, dynamic>> columnData = [
    {"label": "ID", "numeric": true},
    {"label": "Kod"},
    {"label": "Naziv"},
    {"label": "Početak"},
    {"label": "Status"},
    {"label": "Broj iskoristivosti", "numeric": true},
    {"label": "Popust", "numeric": true},
    {"label": "Kreirao"},
    {"label": "", "numeric": true}, // Prazna kolona za dugmad
  ];

  @override
  void initState() {
    super.initState();

    _kuponiProvider = context.read<KuponiProvider>();

    _initialValue = {
      'OrderBy': 'id ASC',
      'status': null,
      'datumPocetka': null,
      'kodGTE': null,
      'brojIskoristivostiGTE': null,
      'popustGTE': null,
    };

    initTable();
  }

  Future initTable() async {
    String orderByField = _formKey.currentState?.value['OrderByField'] ?? "id";
    String orderByDirection =
        _formKey.currentState?.value['OrderByDirection'] ?? "ASC";

    print(_formKey.currentState?.value);

    kuponiResult = await _kuponiProvider.get(filter: {
      'OrderBy': "$orderByField $orderByDirection",
      'Status': _formKey.currentState?.value['status'],
      'DatumPocetka': _formKey.currentState?.value['datumPocetka'],
      'KodGTE': _formKey.currentState?.value['kodGTE'],
      'BrojIskoristivostiGTE':
          _formKey.currentState?.value['brojIskoristivostiGTE'],
      'PopustGTE': _formKey.currentState?.value['popustGTE'],
    });

    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      selectedIndex: 4,
      headerTitle: "Kuponi",
      headerDescription: "Ovdje možete vidjeti listu kupona",
      child: Container(
        child: Column(
          children: [
            _buildSearch(),
            isLoading ? LoadingSpinnerWidget() : _buildResultView()
          ],
        ),
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
      initialValue: _initialValue,
      child: Padding(
        padding: const EdgeInsets.only(bottom: 20),
        child: Row(
          spacing: 10,
          children: [
            Expanded(
                child: FormBuilderDateTimePicker(
                    name: "datumPocetka",
                    decoration: buildTextFieldDecoration(
                        labelText: "Datum početka",
                        hintText: "Datum početka",
                        prefixIcon: Icon(Icons.date_range_rounded),
                        onClear: () => _formKey
                            .currentState!.fields['datumPocetka']
                            ?.reset()))),
            Expanded(
                child: FormBuilderTextField(
              name: "kodGTE",
              initialValue: _initialValue['kodGTE'],
              decoration: buildTextFieldDecoration(
                  hintText: "Kod...",
                  labelText: "Kod",
                  prefixIcon: Icon(Icons.abc_rounded)),
            )),
            Expanded(
                child: FormBuilderTextField(
              name: "brojIskoristivostiGTE",
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
              initialValue: _initialValue['brojIskoristivostiGTE'],
              decoration: buildTextFieldDecoration(
                  hintText: "Broj iskoristivosti...",
                  labelText: "Broj iskoristivosti",
                  prefixIcon: Icon(Icons.pin_outlined)),
            )),
            Expanded(
                child: FormBuilderTextField(
              name: "popustGTE",
              keyboardType: TextInputType.number,
              valueTransformer: (value) {
                if (value != null) {
                  return double.tryParse(value);
                }
              },
              validator: FormBuilderValidators.compose([
                FormBuilderValidators.float(
                  errorText: 'Ovo polje mora biti broj.',
                ),
              ]),
              initialValue: _initialValue['popustGTE'],
              decoration: buildTextFieldDecoration(
                  hintText: "Popust...",
                  labelText: "Popust",
                  prefixIcon: Icon(Icons.percent)),
            )),
            Expanded(
              child: buildDropdown(
                name: "status",
                labelText: "Status",
                prefixIcon: Icon(Icons.flag),
                items: KuponiStatus.values
                    .map((status) => DropdownMenuItem(
                          value: status.name,
                          child: Text(status.naziv),
                        ))
                    .toList(),
                onClear: () {
                  _formKey.currentState!.fields['status']?.reset();
                },
              ),
            ),
            Expanded(
              child: buildDropdown(
                name: "OrderByField",
                labelText: "Sortiraj po",
                initialValue: "id",
                prefixIcon: Icon(Icons.sort_by_alpha_rounded),
                items: const [
                  DropdownMenuItem(value: "id", child: Text("ID")),
                  DropdownMenuItem(value: "Kod", child: Text("Kod")),
                  DropdownMenuItem(
                      value: "DatumPocetka", child: Text("Datum početka")),
                  DropdownMenuItem(
                      value: "BrojIskoristivosti",
                      child: Text("Broj iskoristivosti")),
                  DropdownMenuItem(value: "Popust", child: Text("Popust")),
                  DropdownMenuItem(
                      value: "DatumIzmjene", child: Text("Datum izmjene")),
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
            CustomButtonWidget(
              buttonText: "Dodaj kupon",
              onPress: () {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => ObavjestenjaDetailsScreen(),
                  ),
                );
              },
            ),
          ],
        ),
      ),
    );
  }

  DataRow _buildDataRow(Kupon e, BuildContext context) {
    return DataRow(
      cells: [
        buildDataCell(e.id?.toString()),
        buildDataCell(e.kod),
        buildDataCell(e.naziv),
        buildDataCell(e.datumPocetka != null
            ? DateFormat('yyyy/MM/dd hh:mm').format(e.datumPocetka!)
            : "N/A"),
        DataCell(
          Badge(
            padding:
                const EdgeInsets.only(left: 5, right: 5, top: 4, bottom: 4),
            label: Text(KuponiStatus.fromString(e.stateMachine)?.naziv ?? ""),
            backgroundColor:
                KuponiStatus.fromString(e.stateMachine)?.boja ?? Colors.red,
          ),
        ),
        buildDataCell(e.brojIskoristivosti.toString()),
        buildDataCell(((e.popust ?? 0) * 100).toString() + "%"),
        if (e.korisnik == null) buildDataCell("Sistem"),
        if (e.korisnik != null)
          buildDataCell(
              "${e.korisnik?.ime ?? ""} ${e.korisnik?.prezime ?? ""}"),
        DataCell(Row(
          children: [
            if (e.stateMachine == 'completed' || e.stateMachine == 'draft')
              IconButton(
                iconSize: 17,
                onPressed: () {},
                icon: const Icon(Icons.delete),
              ),
            if (e.stateMachine != 'completed')
              IconButton(
                onPressed: () {
                  Navigator.of(context)
                      .push(
                        MaterialPageRoute(
                          builder: (context) => ObavjestenjaDetailsScreen(),
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
              columns: columnData.map((col) {
                return DataColumn(
                  label: Text(col["label"], style: columnTextStyle),
                  numeric: col["numeric"] ?? false,
                );
              }).toList(),
              rows: kuponiResult?.result
                      .map((e) => _buildDataRow(e, context))
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
