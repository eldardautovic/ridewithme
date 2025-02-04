import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_admin/models/grad.dart';
import 'package:ridewithme_admin/models/search_result.dart';
import 'package:ridewithme_admin/providers/gradovi_provider.dart';
import 'package:ridewithme_admin/screens/gradovi_details_screen.dart';
import 'package:ridewithme_admin/screens/kuponi_details_screen.dart';
import 'package:ridewithme_admin/utils/input_utils.dart';
import 'package:ridewithme_admin/utils/table_utils.dart';
import 'package:ridewithme_admin/widgets/custom_button_widget.dart';
import 'package:ridewithme_admin/widgets/loading_spinner_widget.dart';
import 'package:ridewithme_admin/widgets/master_screen.dart';

class GradoviScreen extends StatefulWidget {
  const GradoviScreen({super.key});

  @override
  State<GradoviScreen> createState() => _GradoviScreenState();
}

class _GradoviScreenState extends State<GradoviScreen> {
  late GradoviProvider _gradoviProvider;

  SearchResult<Gradovi>? gradoviResult;

  final _formKey = GlobalKey<FormBuilderState>();

  bool isLoading = true;

  final List<Map<String, dynamic>> columnData = [
    {"label": "ID", "numeric": true},
    {"label": "Naziv"},
    {"label": "Geo. dužina"},
    {"label": "Geo. širina"},
    {"label": "", "numeric": true}, // Prazna kolona za dugmad
  ];

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _gradoviProvider = context.read<GradoviProvider>();

    initTable();
  }

  Future initTable() async {
    gradoviResult = await _gradoviProvider
        .get(filter: {"NazivGTE": _formKey.currentState?.value['NazivGTE']});

    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      headerTitle: "Gradovi",
      headerDescription:
          "Ovdje možete da pregledate i dodate nove/postojeće gradove.",
      selectedIndex: 8,
      child: Column(
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
                name: "NazivGTE",
                decoration: buildTextFieldDecoration(
                    hintText: "Naziv...",
                    labelText: "Naziv",
                    prefixIcon: Icon(Icons.abc_rounded)),
              )),
              CustomButtonWidget(
                buttonText: "Dodaj grad",
                onPress: () {
                  Navigator.of(context).push(
                    MaterialPageRoute(
                      builder: (context) => GradoviDetailsScreen(),
                    ),
                  );
                },
              ),
            ],
          ),
        ),
      ),
    );
  }

  DataRow _buildDataRow(Gradovi e, BuildContext context) {
    return DataRow(
      cells: [
        buildDataCell(e.id?.toString()),
        buildDataCell(e.naziv.toString()),
        buildDataCell(e.longitude.toString()),
        buildDataCell(e.latitude.toString()),
        DataCell(Row(
          children: [
            IconButton(
              onPressed: () {
                Navigator.of(context)
                    .push(
                      MaterialPageRoute(
                        builder: (context) => GradoviDetailsScreen(
                          grad: e,
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
    return Expanded(
      child: SizedBox(
        width: MediaQuery.of(context).size.width / 3, // Expands to full width
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
              rows: gradoviResult?.result
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
