import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_mobile/layouts/master_layout.dart';
import 'package:ridewithme_mobile/models/voznja.dart';
import 'package:ridewithme_mobile/providers/korisnik_provider.dart';
import 'package:ridewithme_mobile/providers/voznje_provider.dart';
import 'package:ridewithme_mobile/widgets/loading_spinner_widget.dart';

class VoznjeDetailsScreen extends StatefulWidget {
  Voznja voznja;
  VoznjeDetailsScreen({super.key, required this.voznja});

  @override
  State<VoznjeDetailsScreen> createState() => _VoznjeDetailsScreenState();
}

class _VoznjeDetailsScreenState extends State<VoznjeDetailsScreen> {
  late VoznjeProvider _voznjeProvider;
  late KorisnikProvider _korisnikProvider;

  bool isLoading = true;

  bool isTrusted = false;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _voznjeProvider = context.read<VoznjeProvider>();
    _korisnikProvider = context.read<KorisnikProvider>();

    initTrusted();
  }

  Future initTrusted() async {
    var result = await _korisnikProvider.trusted(widget.voznja.vozac?.id ?? 0);
    print(result);

    if (result > 0) {
      isTrusted = true;
    }

    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterLayout(
        selectedIndex: 1,
        child: Padding(
          padding: const EdgeInsets.all(20.0),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              _buildHeader(),
              _buildInfo(),
              isLoading ? LoadingSpinnerWidget(height: 100) : _buildTrusted()
            ],
          ),
        ));
  }

  Widget _buildHeader() {
    return Container(
      decoration: BoxDecoration(
          color: Color(0xFF7463DE).withAlpha(60),
          borderRadius: BorderRadius.circular(15)),
      child: Padding(
        padding: const EdgeInsets.all(20.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          spacing: 20,
          children: [
            Row(
              spacing: 10,
              children: [
                SizedBox(
                  height: 150,
                  width: 10,
                  child: DecoratedBox(
                      decoration: BoxDecoration(color: Color(0xFF7463DE))),
                ),
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text(
                      widget.voznja.gradOd?.naziv ?? '',
                      style: _buildTextStyle(),
                    ),
                    Text(
                      "Do",
                      style: _buildTextStyle(),
                    ),
                    Text(widget.voznja.gradDo?.naziv ?? '',
                        style: _buildTextStyle())
                  ],
                )
              ],
            ),
            Row(
              children: [
                Text("Vozač: ",
                    style: TextStyle(
                        fontFamily: "Inter",
                        fontSize: 12,
                        color: Colors.black,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  width: 5,
                ),
                Container(
                  width: 25,
                  height: 25,
                  decoration: BoxDecoration(
                      color: Colors.amber,
                      borderRadius: BorderRadius.circular(100)),
                ),
                SizedBox(
                  width: 5,
                ),
                Text(
                  "${widget.voznja.vozac?.ime ?? ''} ${widget.voznja.vozac?.prezime ?? ''}",
                  overflow: TextOverflow.ellipsis,
                  style: TextStyle(
                      fontFamily: "Inter",
                      fontSize: 12,
                      color: Colors.black,
                      fontWeight: FontWeight.normal),
                ),
                SizedBox(
                  width: 20,
                ),
              ],
            )
          ],
        ),
      ),
    );
  }

  Widget _buildInfo() {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        SizedBox(
          height: 20,
        ),
        RichText(
          text: TextSpan(
              text: "Polazak:",
              children: [
                TextSpan(
                    text:
                        " ${DateFormat("dd.MM.yyyy u hh:mm").format(widget.voznja.datumVrijemePocetka ?? DateTime.now())}",
                    style: TextStyle(
                        fontFamily: "Inter",
                        fontSize: 13,
                        color: Colors.black,
                        fontWeight: FontWeight.normal))
              ],
              style: TextStyle(
                  fontFamily: "Inter",
                  fontSize: 13,
                  color: Colors.black,
                  fontWeight: FontWeight.bold)),
        ),
        SizedBox(
          height: 20,
        ),
      ],
    );
  }

  Widget _buildTrusted() {
    return Container(
        width: double.infinity,
        decoration: BoxDecoration(
            color: isTrusted
                ? Color(0xFF39D5C3).withAlpha(60)
                : Color(0xFFE14040).withAlpha(40),
            borderRadius: BorderRadius.circular(15)),
        child: Stack(
          children: [
            Positioned(
              child: Icon(
                isTrusted
                    ? Icons.sentiment_satisfied_rounded
                    : Icons.sentiment_dissatisfied_rounded,
                size: 100,
                color: Colors.black.withAlpha(20),
              ),
              bottom: -20,
              right: 10,
            ),
            Padding(
              padding: const EdgeInsets.only(
                  top: 20, left: 15, right: 15, bottom: 20),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                spacing: 5,
                children: [
                  Text(
                    isTrusted ? "Provjeren vozač" : "Neprovjeren vozač",
                    style: TextStyle(
                        fontFamily: "Inter",
                        fontSize: 16,
                        color: Colors.black,
                        fontWeight: FontWeight.bold),
                  ),
                  Text(
                    isTrusted
                        ? "Ovaj vozač ima 140 uspješnih vožnji"
                        : "Ovaj vozač nema nijednu završenu vožnju.",
                    style: TextStyle(
                        fontFamily: "Inter",
                        fontSize: 13,
                        color: Colors.black,
                        fontWeight: FontWeight.normal),
                  ),
                ],
              ),
            )
          ],
        ));
  }

  TextStyle _buildTextStyle() {
    return TextStyle(
        fontFamily: "Inter",
        fontSize: 30,
        color: Color(0xFF7463DE),
        fontWeight: FontWeight.w900);
  }
}
