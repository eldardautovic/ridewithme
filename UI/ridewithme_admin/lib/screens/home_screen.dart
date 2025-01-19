import 'package:flutter/material.dart';
import 'package:ridewithme_admin/models/card_item_model.dart';
import 'package:ridewithme_admin/widgets/info_card_widget.dart';
import 'package:ridewithme_admin/widgets/master_screen.dart';

class HomeScreen extends StatefulWidget {
  const HomeScreen({super.key});

  @override
  State<HomeScreen> createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {
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
  Widget build(BuildContext context) {
    return MasterScreenWidget(
        selectedIndex: 0,
        child: Container(
          child: Column(
            children: [
              Row(
                spacing: 10,
                crossAxisAlignment:
                    CrossAxisAlignment.start, // Align to the top
                mainAxisAlignment: MainAxisAlignment
                    .spaceBetween, // Align to the top horizontally
                children: _cardItems
                    .map((e) => InfoCardWidget(
                          cardTitle: e.title,
                          cardSubtitle: e.subtitle,
                          cardValue: e.value,
                        ))
                    .toList(),
              )
            ],
          ),
        ));
  }
}
