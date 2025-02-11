import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_admin/models/poslovni_izvjestaj.dart';
import 'package:ridewithme_admin/providers/statistika_provider.dart';
import 'package:ridewithme_admin/screens/analitika_screen.dart';
import 'package:ridewithme_admin/utils/table_utils.dart';
import 'package:ridewithme_admin/widgets/custom_button_widget.dart';
import 'package:ridewithme_admin/widgets/master_screen.dart';

class PoslovniIzvjestajScreen extends StatefulWidget {
  const PoslovniIzvjestajScreen({super.key});

  @override
  State<PoslovniIzvjestajScreen> createState() =>
      _PoslovniIzvjestajScreenState();
}

class _PoslovniIzvjestajScreenState extends State<PoslovniIzvjestajScreen> {
  late StatistikaProvider _statistikaProvider;

  List<PoslovniIzvjestaj>? izvjestajResult;

  bool isLoading = true;

  final List<Map<String, dynamic>> columnData = [
    {"label": "Godina"},
    {"label": "Broj administratora"},
    {"label": "Broj korisnika"},
    {"label": "Broj kreiranih kupona"},
    {"label": "Broj iskorištenih kupona"},
    {"label": "Broj vožnji"},
    {"label": "Prihodi"},
  ];

  @override
  void initState() {
    // TODO: implement initState
    super.initState();

    _statistikaProvider = context.read<StatistikaProvider>();

    _initReport();
  }

  Future _initReport() async {
    izvjestajResult = await _statistikaProvider.getBusinessReport();

    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      selectedIndex: 1,
      backButton: AnalitikaScreen(),
      headerTitle: "Poslovni izvještaj",
      headerDescription:
          "Ovdje možete da pogledate poslovni izvještaj i printate isti.",
      child: Column(
        spacing: 10,
        children: [_buildPrintButton(), _buildResultView()],
      ),
    );
  }

  Widget _buildPrintButton() {
    return Row(
      mainAxisAlignment: MainAxisAlignment.end,
      children: [CustomButtonWidget(buttonText: "Printaj", onPress: () {})],
    );
  }

  DataRow _buildDataRow(PoslovniIzvjestaj e, BuildContext context, int index) {
    return DataRow(
      color: WidgetStatePropertyAll(
          index % 2 == 0 ? Color(0x808E9EE6) : Color(0x4F8E9EE6)),
      cells: [
        buildReportCell(e.godina?.toString()),
        buildReportCell(e.brojAdministratora?.toString()),
        buildReportCell(e.brojKorisnika.toString()),
        buildReportCell(e.brojKreiranihKupona.toString()),
        buildReportCell(e.brojIskoristenihKupona.toString()),
        buildReportCell(e.brojVoznji.toString()),
        buildReportCell(e.prihodiVozaca.toString() + " KM"),
      ],
    );
  }

  Widget _buildResultView() {
    if (isLoading == false &&
        izvjestajResult != null &&
        izvjestajResult?.isEmpty == true) {
      return Text("Nema rezultata.");
    }

    return SizedBox(
      width: double.infinity,
      child: Container(
        decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(20),
          border: Border.all(color: Color(0xFFD3D3D3)),
        ),
        child: ClipRRect(
          borderRadius: BorderRadius.circular(20), // Dodajte ovde borderRadius
          child: SingleChildScrollView(
            child: DataTable(
              showCheckboxColumn: false,
              columnSpacing: 25,
              border: TableBorder(
                borderRadius: BorderRadius.circular(20),
                horizontalInside: const BorderSide(
                  width: 1,
                  color: Color(0xFF8E9EE6),
                ),
              ),
              columns: columnData.map((col) {
                return DataColumn(
                  label: Text(
                    col["label"],
                    style: TextStyle(
                      color: Color(0xFF565252),
                      fontFamily: "Inter",
                      fontWeight: FontWeight.w700,
                      fontSize: 14,
                    ),
                  ),
                  numeric: true,
                );
              }).toList(),
              rows: izvjestajResult
                      ?.asMap()
                      .entries
                      .map((entry) =>
                          _buildDataRow(entry.value, context, entry.key))
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
