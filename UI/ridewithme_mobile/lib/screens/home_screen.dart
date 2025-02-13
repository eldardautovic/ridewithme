import 'package:carousel_slider/carousel_slider.dart';
import 'package:flutter/material.dart';
import 'package:ridewithme_mobile/layouts/master_layout.dart';
import 'package:ridewithme_mobile/models/grad.dart';
import 'package:ridewithme_mobile/models/korisnik.dart';
import 'package:ridewithme_mobile/models/kupon.dart';
import 'package:ridewithme_mobile/models/obavjestenje.dart';
import 'package:ridewithme_mobile/models/voznja.dart';
import 'package:ridewithme_mobile/utils/auth_util.dart';
import 'package:ridewithme_mobile/widgets/notice_widget.dart';
import 'package:ridewithme_mobile/widgets/ride_widget.dart';

class HomeScreen extends StatefulWidget {
  const HomeScreen({super.key});

  @override
  State<HomeScreen> createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {
  @override
  Widget build(BuildContext context) {
    return MasterLayout(
      selectedIndex: 0,
      child: Column(
        spacing: 15,
        children: [
          _buildWelcomeCard(),
          _buildRecommendedRides(),
          _buildNotices()
        ],
      ),
    );
  }

  Widget _buildNotices() {
    List<Obavjestenje> obavjestenja = List.generate(
      3,
      (index) => Obavjestenje(index, 'active', 'Neki naslov obavjestenja',
          "Neki podnaslov", null, null, null, null, null),
    );

    return CarouselSlider(
      options: CarouselOptions(
        height: 160,
        enableInfiniteScroll: true,
        viewportFraction: 0.9,
        enlargeStrategy: CenterPageEnlargeStrategy.scale,
      ),
      items: obavjestenja.map((obavjestenje) {
        return NoticeWidget(
          obavjestenje: obavjestenje,
          boxColor: Color(0xFFFCFC00),
        );
      }).toList(),
    );
  }

  Widget _buildRecommendedRides() {
    List<Voznja> rides = List.generate(
      3,
      (index) => Voznja(
        1,
        "active",
        DateTime.now(),
        DateTime.now(),
        1,
        50,
        "Hi",
        Gradovi(1, "Travnik", 1323, 4242),
        Gradovi(2, "Sarajevo", 2324, 5252),
        Korisnik(1, "Eldar", "Prezime", null, null, null, null),
        Korisnik(2, "Drugi", "Prezime", null, null, null, null),
        Kupon(
          1,
          "KOD",
          "Naziv kupona",
          DateTime.now(),
          5,
          'active',
          0.9,
          Korisnik(1, "Eldar", "Prezime", null, null, null, null),
          DateTime.now(),
        ),
        null,
      ),
    );

    return Column(
      spacing: 10,
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Padding(
          padding: const EdgeInsets.all(10.0),
          child: Text(
            "Vožnje koje bi vas mogle zanimati:",
            style: TextStyle(
                fontFamily: "Inter",
                color: Colors.black,
                fontSize: 12,
                fontWeight: FontWeight.w500),
          ),
        ),
        CarouselSlider(
          options: CarouselOptions(
            height: 160,
            enableInfiniteScroll: true,
            autoPlay: false,
            viewportFraction: 0.55,
            enlargeStrategy: CenterPageEnlargeStrategy.scale,
          ),
          items: rides.map((voznja) {
            return RideWidget(
              voznja: voznja,
              boxColor: Color(0xFF8E9EE6),
            );
          }).toList(),
        ),
      ],
    );
  }

  Widget _buildWelcomeCard() {
    return Padding(
      padding: const EdgeInsets.only(top: 20, left: 10, right: 10),
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
