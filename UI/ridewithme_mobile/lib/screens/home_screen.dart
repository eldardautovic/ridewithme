import 'package:carousel_slider/carousel_slider.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_mobile/layouts/master_layout.dart';
import 'package:ridewithme_mobile/models/grad.dart';
import 'package:ridewithme_mobile/models/korisnik.dart';
import 'package:ridewithme_mobile/models/kupon.dart';
import 'package:ridewithme_mobile/models/obavjestenje.dart';
import 'package:ridewithme_mobile/models/search_result.dart';
import 'package:ridewithme_mobile/models/voznja.dart';
import 'package:ridewithme_mobile/providers/obavjestenja_provider.dart';
import 'package:ridewithme_mobile/providers/voznje_provider.dart';
import 'package:ridewithme_mobile/utils/auth_util.dart';
import 'package:ridewithme_mobile/widgets/avatar_widget.dart';
import 'package:ridewithme_mobile/widgets/custom_button_widget.dart';
import 'package:ridewithme_mobile/widgets/loading_spinner_widget.dart';
import 'package:ridewithme_mobile/widgets/notice_widget.dart';
import 'package:ridewithme_mobile/widgets/ride_widget.dart';

class HomeScreen extends StatefulWidget {
  const HomeScreen({super.key});

  @override
  State<HomeScreen> createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {
  late VoznjeProvider _voznjeProvider;
  late ObavjestenjaProvider _obavjestenjaProvider;

  bool recommendedRidesLoading = true;
  bool cheapRidesLoading = true;
  bool noticesLoading = true;

  SearchResult<Voznja>? recommendedRides;
  SearchResult<Voznja>? cheapRides;
  SearchResult<Obavjestenje>? notices;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();

    _voznjeProvider = context.read<VoznjeProvider>();
    _obavjestenjaProvider = context.read<ObavjestenjaProvider>();

    initHomepage();
  }

  Future initHomepage() async {
    recommendedRides = await _voznjeProvider.get(filter: {
      "IsGradoviIncluded": true,
      'IsKorisniciIncluded': true,

      //  "Status": "active"
    });

    cheapRides = await _voznjeProvider.get(filter: {
      "IsGradoviIncluded": true,
      "OrderBy": "Cijena asc",
      'IsKorisniciIncluded': true,

      // "Status": "active"
    });

    notices = await _obavjestenjaProvider.get();

    setState(() {
      recommendedRidesLoading = false;
      cheapRidesLoading = false;
      noticesLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterLayout(
      selectedIndex: 0,
      child: Flexible(
        child: SingleChildScrollView(
          child: Column(
            spacing: 15,
            children: [
              _buildWelcomeCard(),
              _buildRecommendedRides(),
              _buildNotices(),
              _buildPopularDrivers(),
              _buildCheapRides(),
              _buildSorryScreen()
            ],
          ),
        ),
      ),
    );
  }

  Widget _buildSorryScreen() {
    if (recommendedRides?.count == 0 &&
        cheapRides?.count == 0 &&
        !recommendedRidesLoading &&
        !cheapRidesLoading) {
      return Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: [
          Icon(
            Icons.info_outline,
            size: 50,
            color: Colors.grey,
          ),
          SizedBox(height: 10),
          Text(
            'Trenutno nema dostupnih vožnji.',
            style: TextStyle(fontSize: 16, color: Colors.grey),
            textAlign: TextAlign.center,
          ),
          SizedBox(height: 10),
          CustomButtonWidget(
            buttonText: "Kreiraj vožnju",
            onPress: () {},
            fontSize: 12,
          ) //TODO: Dodaj navigator do kreiranja
        ],
      );
    }

    return SizedBox.shrink();
  }

  Widget _buildNotices() {
    if (!noticesLoading && notices?.count == 0) {
      return Container();
    }

    return noticesLoading
        ? LoadingSpinnerWidget(height: 170)
        : CarouselSlider(
            options: CarouselOptions(
              height: 170,
              enableInfiniteScroll: true,
              viewportFraction: 0.9,
              enlargeStrategy: CenterPageEnlargeStrategy.scale,
            ),
            items: notices?.result.map((obavjestenje) {
                  return NoticeWidget(
                    obavjestenje: obavjestenje,
                    boxColor: Color(0xFFFCFC00),
                  );
                }).toList() ??
                [],
          );
  }

  Widget _buildPopularDrivers() {
    List<Korisnik> korisnici = List.generate(
      5,
      (index) => Korisnik(index, "Eldar", "Prezime", null, null, null, null),
    );

    return Column(
      spacing: 10,
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Padding(
          padding: const EdgeInsets.only(bottom: 10.0, top: 10, left: 20),
          child: Text(
            "Popularni vozači:",
            style: TextStyle(
                fontFamily: "Inter",
                color: Colors.black,
                fontSize: 12,
                fontWeight: FontWeight.w500),
          ),
        ),
        CarouselSlider(
          options: CarouselOptions(
            height: 65,
            enableInfiniteScroll: true,
            viewportFraction: 0.4,
            enlargeStrategy: CenterPageEnlargeStrategy.scale,
          ),
          items: korisnici.map((korisnik) {
            return AvatarWidget(
              korisnik: korisnik,
            );
          }).toList(),
        )
      ],
    );
  }

  Widget _buildRecommendedRides() {
    if (!recommendedRidesLoading && recommendedRides?.count == 0) {
      return Container();
    }

    return Column(
      spacing: 10,
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Padding(
          padding: const EdgeInsets.only(bottom: 10.0, top: 10, left: 20),
          child: Text(
            "Vožnje koje bi vas mogle zanimati:",
            style: TextStyle(
                fontFamily: "Inter",
                color: Colors.black,
                fontSize: 12,
                fontWeight: FontWeight.w500),
          ),
        ),
        recommendedRidesLoading
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
                items: recommendedRides?.result.map((voznja) {
                      return RideWidget(
                        voznja: voznja,
                        boxColor: Color(0xFF7463DE),
                      );
                    }).toList() ??
                    [],
              ),
      ],
    );
  }

  Widget _buildCheapRides() {
    if (!cheapRidesLoading && cheapRides?.count == 0) {
      return Container();
    }

    return Container(
      margin: EdgeInsets.only(bottom: 20),
      child: Column(
        spacing: 10,
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Padding(
            padding: const EdgeInsets.only(bottom: 10.0, top: 10, left: 20),
            child: Text(
              "Jeftine vožnje:",
              style: TextStyle(
                  fontFamily: "Inter",
                  color: Colors.black,
                  fontSize: 12,
                  fontWeight: FontWeight.w500),
            ),
          ),
          cheapRidesLoading
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

  Widget _buildWelcomeCard() {
    return Padding(
      padding: const EdgeInsets.only(top: 20, left: 20, right: 20),
      child: Container(
        decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(15),
          gradient: LinearGradient(
              colors: [Color(0xB339D5C3), Color(0xB37463DE)],
              begin: Alignment.topLeft,
              end: Alignment(1, 1)),
        ),
        alignment: Alignment.centerLeft,
        child: Padding(
          padding: const EdgeInsets.all(20.0),
          child: Text("Dobrodošli, ${Authorization.fullName}!",
              style: TextStyle(
                  fontFamily: "Inter",
                  fontSize: 16,
                  fontWeight: FontWeight.bold),
              overflow: TextOverflow.ellipsis),
        ),
      ),
    );
  }
}
