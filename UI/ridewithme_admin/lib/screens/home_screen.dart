import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_admin/models/card_item_model.dart';
import 'package:ridewithme_admin/providers/statistika_provider.dart';
import 'package:ridewithme_admin/utils/util.dart';
import 'package:ridewithme_admin/widgets/info_card_widget.dart';
import 'package:ridewithme_admin/widgets/master_screen.dart';

class HomeScreen extends StatefulWidget {
  const HomeScreen({super.key});

  @override
  State<HomeScreen> createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {
  late StatistikaProvider _statistikaProvider;

  var _cardItems = [
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

  bool isLoading = true;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _statistikaProvider = context.read<StatistikaProvider>();

    initCards();
  }

  Future initCards() async {
    var result = await _statistikaProvider.get();

    _cardItems = [
      CardItemModel(
          title: "Korisnici",
          subtitle: "Ukupno registrovanih korisnika",
          value: result.result[0].brojRegistrovanihKorisnika.toString()),
      CardItemModel(
          title: "Vožnje",
          subtitle: "Broj kreiranih vožnji",
          value: result.result[0].brojKreiranihVoznji.toString()),
      CardItemModel(
          title: "Kuponi",
          subtitle: "Broj iskorištenih kupona",
          value: result.result[0].brojIskoristenihKupona.toString())
    ];

    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
        selectedIndex: 0,
        child: Container(
          child: isLoading
              ? CircularProgressIndicator()
              : Column(
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
                    ),
                    SizedBox(
                      height: 10,
                    ),
                    Row(
                      children: [
                        Expanded(
                            child: Container(
                          decoration: BoxDecoration(
                            borderRadius: BorderRadius.circular(15),
                            color: Color(0x29C3CBCA),
                          ),
                          width: 20,
                          child: Padding(
                            padding: const EdgeInsets.all(20.0),
                            child: Text(
                              "Dobrodošli! ${Authorization.fullName}",
                              style: TextStyle(
                                  fontFamily: "Inter",
                                  fontSize: 18,
                                  fontWeight: FontWeight.w800),
                            ),
                          ),
                        ))
                      ],
                    )
                  ],
                ),
        ));
  }
}
