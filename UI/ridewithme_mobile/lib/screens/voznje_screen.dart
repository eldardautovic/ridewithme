import 'package:carousel_slider/carousel_options.dart';
import 'package:carousel_slider/carousel_slider.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_mobile/layouts/master_layout.dart';
import 'package:ridewithme_mobile/models/grad.dart';
import 'package:ridewithme_mobile/models/search_result.dart';
import 'package:ridewithme_mobile/models/voznja.dart';
import 'package:ridewithme_mobile/providers/gradovi_provider.dart';
import 'package:ridewithme_mobile/providers/voznje_provider.dart';
import 'package:ridewithme_mobile/widgets/loading_spinner_widget.dart';
import 'package:ridewithme_mobile/widgets/ride_widget.dart';
import 'package:ridewithme_mobile/widgets/town_widget.dart';

class VoznjeScreen extends StatefulWidget {
  const VoznjeScreen({super.key});

  @override
  State<VoznjeScreen> createState() => _VoznjeScreenState();
}

class _VoznjeScreenState extends State<VoznjeScreen> {
  late VoznjeProvider _voznjeProvider;
  late GradoviProvider _gradoviProvider;

  SearchResult<Voznja>? recentRides;
  SearchResult<Voznja>? cheapRides;
  SearchResult<Gradovi>? gradoviResults;

  bool isLoading = true;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _voznjeProvider = context.read<VoznjeProvider>();
    _gradoviProvider = context.read<GradoviProvider>();

    initPage();
  }

  Future initPage() async {
    recentRides = await _voznjeProvider.get(filter: {
      "IsGradoviIncluded": true,
      //  "Status": "active",
      "OrderBy": "DatumKreiranja DESC"
    });

    cheapRides = await _voznjeProvider.get(filter: {
      "IsGradoviIncluded": true,
      "OrderBy": "Cijena asc",
      // "Status": "active"
    });

    gradoviResults = await _gradoviProvider.get();

    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterLayout(
      selectedIndex: 1,
      header: "Vožnje",
      headerDescription: "Ovdje možete da pronađete vožnje ",
      headerColor: Color(0xFF7463DE),
      child: Flexible(
        child: SingleChildScrollView(
          child: Column(
            spacing: 15,
            children: [
              Padding(
                padding: const EdgeInsets.only(left: 20, bottom: 10.0, top: 10),
                child: CupertinoSearchTextField(
                  placeholder: "Pretraži vožnje...",
                  onTap: () {
                    print("Vodi do voznje search ekrana");
                  },
                  decoration: BoxDecoration(
                    border: Border.all(color: Color(0xFFE3E3E3), width: 1),
                    color: Color(0xFFF3FCFC),
                    borderRadius: BorderRadius.circular(5),
                  ),
                ),
              ),
              _buildTownList(),
              _buildRecentRides(),
              _buildCheapRides(),
            ],
          ),
        ),
      ),
    );
  }

  Widget _buildTownList() {
    if (!isLoading && cheapRides?.count == 0) {
      return Container();
    }

    return Column(
      spacing: 10,
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Padding(
          padding: const EdgeInsets.only(left: 20, bottom: 10.0, top: 10),
          child: Text(
            "Gdje želite da putujete?",
            style: TextStyle(
                fontFamily: "Inter",
                color: Colors.black,
                fontSize: 12,
                fontWeight: FontWeight.w500),
          ),
        ),
        isLoading
            ? LoadingSpinnerWidget(
                height: 65,
              )
            : CarouselSlider(
                options: CarouselOptions(
                  height: 65,
                  enableInfiniteScroll: true,
                  viewportFraction: 0.4,
                  enlargeStrategy: CenterPageEnlargeStrategy.scale,
                ),
                items: gradoviResults?.result.map((grad) {
                      return TownWidget(
                        grad: grad,
                      );
                    }).toList() ??
                    [],
              )
      ],
    );
  }

  Widget _buildCheapRides() {
    if (!isLoading && cheapRides?.count == 0) {
      return Container();
    }

    return Container(
      margin: EdgeInsets.only(bottom: 20),
      child: Column(
        spacing: 10,
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Padding(
            padding: const EdgeInsets.only(left: 20, bottom: 10.0, top: 10),
            child: Text(
              "Jeftine vožnje:",
              style: TextStyle(
                  fontFamily: "Inter",
                  color: Colors.black,
                  fontSize: 12,
                  fontWeight: FontWeight.w500),
            ),
          ),
          isLoading
              ? LoadingSpinnerWidget(
                  height: 160,
                )
              : CarouselSlider(
                  options: CarouselOptions(
                    height: 160,
                    enableInfiniteScroll: true,
                    autoPlay: false,
                    viewportFraction: 0.55,
                    enlargeStrategy: CenterPageEnlargeStrategy.scale,
                  ),
                  items: cheapRides?.result.map((voznja) {
                        return RideWidget(
                          voznja: voznja,
                          boxColor: Color(0xFF39D5C3),
                        );
                      }).toList() ??
                      [],
                ),
        ],
      ),
    );
  }

  Widget _buildRecentRides() {
    if (!isLoading && recentRides?.count == 0) {
      return Container();
    }

    return Container(
      margin: EdgeInsets.only(bottom: 20),
      child: Column(
        spacing: 10,
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Padding(
            padding: const EdgeInsets.only(left: 20, bottom: 10.0, top: 10),
            child: Text(
              "Nedavno objavljene vožnje:",
              style: TextStyle(
                  fontFamily: "Inter",
                  color: Colors.black,
                  fontSize: 12,
                  fontWeight: FontWeight.w500),
            ),
          ),
          isLoading
              ? LoadingSpinnerWidget(
                  height: 160,
                )
              : CarouselSlider(
                  options: CarouselOptions(
                    height: 160,
                    enableInfiniteScroll: true,
                    autoPlay: false,
                    viewportFraction: 0.55,
                    enlargeStrategy: CenterPageEnlargeStrategy.scale,
                  ),
                  items: recentRides?.result.map((voznja) {
                        return RideWidget(
                          voznja: voznja,
                          boxColor: Color(0xFF7463DE),
                        );
                      }).toList() ??
                      [],
                ),
        ],
      ),
    );
  }
}
