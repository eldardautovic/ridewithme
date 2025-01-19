import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_admin/providers/voznje_provider.dart';
import 'package:ridewithme_admin/widgets/info_card_widget.dart';
import 'package:ridewithme_admin/widgets/master_screen.dart';

class VoznjeListScreen extends StatefulWidget {
  const VoznjeListScreen({super.key});

  @override
  State<VoznjeListScreen> createState() => _VoznjeListScreenState();
}

class _VoznjeListScreenState extends State<VoznjeListScreen> {
  late VoznjeProvider _voznjeProvider;

  final _cardItems = const [
    CardItemModel(
        title: "Korisnici",
        subtitle: "Ukupno registrovanih korisnika",
        value: "150,000"),
    CardItemModel(
        title: "Aktivne vožnje",
        subtitle: "Broj aktivnih kreiranih vožnji",
        value: "154"),
    CardItemModel(
        title: "Kuponi", subtitle: "Broj iskorištenih kupona", value: "55")
  ];

  @override
  void didChangeDependencies() {
    super.didChangeDependencies();
    _voznjeProvider = context.read<VoznjeProvider>();
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Row(
        spacing: 10,
        crossAxisAlignment: CrossAxisAlignment.start, // Align to the top
        mainAxisAlignment:
            MainAxisAlignment.spaceBetween, // Align to the top horizontally
        children: _cardItems
            .map((e) => InfoCardWidget(
                  cardTitle: e.title,
                  cardSubtitle: e.subtitle,
                  cardValue: e.value,
                ))
            .toList(),
      ),
    );
  }
}

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

class CardItemModel {
  const CardItemModel({
    required this.title,
    required this.subtitle,
    required this.value,
  });

  final String title;
  final String subtitle;
  final String value;
}
