import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_admin/models/search_result.dart';
import 'package:ridewithme_admin/models/voznja.dart';
import 'package:ridewithme_admin/providers/voznje_provider.dart';
import 'package:ridewithme_admin/widgets/custom_button_widget.dart';
import 'package:ridewithme_admin/widgets/custom_input_widget.dart';
import 'package:ridewithme_admin/widgets/info_card_widget.dart';
import 'package:ridewithme_admin/widgets/master_screen.dart';

class VoznjeListScreen extends StatefulWidget {
  const VoznjeListScreen({super.key});

  @override
  State<VoznjeListScreen> createState() => _VoznjeListScreenState();
}

class _VoznjeListScreenState extends State<VoznjeListScreen> {
  late VoznjeProvider _voznjeProvider;

  SearchResult<Voznja>? result = null;

  @override
  void didChangeDependencies() {
    super.didChangeDependencies();
    _voznjeProvider = context.read<VoznjeProvider>();
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
        selectedIndex: 3,
        headerTitle: "Vožnje",
        headerDescription: "Ovdje možete pronaći listu vožnji.",
        child: Container(
          child: Column(
            children: [_buildSearch(), _buildResultView()],
          ),
        ));
  }

  TextEditingController _gradDoIdController = TextEditingController();
  TextEditingController _gradOdIdController = TextEditingController();

  Widget _buildSearch() {
    return Padding(
        padding: EdgeInsets.only(bottom: 20),
        child: Row(
          spacing: 10,
          children: [
            Expanded(
                child: CustomInputField(
                    labelText: "Grad od id", controller: _gradOdIdController)),
            Expanded(
                child: CustomInputField(
                    labelText: "Grad do id", controller: _gradDoIdController)),
            Expanded(child: CustomInputField(labelText: "Korisnik id")),
            Container(
                width: 200,
                child: CustomButtonWidget(
                    buttonText: "Pretraži",
                    onPress: () async {
                      //TODO: add call to api

                      var filters = {
                        'GradOdId': _gradOdIdController.text,
                        'GradDoId': _gradDoIdController.text,
                        'IsGradoviIncluded': true
                      };

                      result = await _voznjeProvider.get(filter: filters);

                      setState(() {});
                    })),
          ],
        ));
  }

  Widget _buildResultView() {
    return Expanded(
        child: SingleChildScrollView(
            child: DataTable(
      columns: [
        DataColumn(label: Text("ID"), numeric: true),
        DataColumn(label: Text("Grad od ID")),
      ],
      rows: result?.result
              .map((e) => DataRow(cells: [
                    DataCell(Text(e.id.toString())),
                    DataCell(Text(e.stateMachine ?? ""))
                  ]))
              .toList()
              .cast<DataRow>() ??
          [],
    )));
  }
}

// za screen home
// Column(
//         children: [
//           Row(
//             spacing: 10,
//             crossAxisAlignment: CrossAxisAlignment.start, // Align to the top
//             mainAxisAlignment:
//                 MainAxisAlignment.spaceBetween, // Align to the top horizontally
//             children: _cardItems
//                 .map((e) => InfoCardWidget(
//                       cardTitle: e.title,
//                       cardSubtitle: e.subtitle,
//                       cardValue: e.value,
//                     ))
//                 .toList(),
//           ),
//         ],
//       ),

//     child: Container(
//   child: Column(
//     children: [
//       Text("Elce fukaresina"),
//       ElevatedButton(
//           onPressed: () async {
//             var data = await _voznjeProvider.get();

//             print(data);
//           },
//           child: Text("Vrati me"))
//     ],
//   ),
// ));
