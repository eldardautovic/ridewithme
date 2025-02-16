import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_mobile/layouts/master_layout.dart';
import 'package:ridewithme_mobile/models/kupon_check.dart';
import 'package:ridewithme_mobile/models/voznja.dart';
import 'package:ridewithme_mobile/providers/korisnik_provider.dart';
import 'package:ridewithme_mobile/providers/kuponi_provider.dart';
import 'package:ridewithme_mobile/providers/voznje_provider.dart';
import 'package:ridewithme_mobile/widgets/custom_button_widget.dart';
import 'package:ridewithme_mobile/widgets/custom_input_widget.dart';
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
  late KuponiProvider _kuponiProvider;

  TextEditingController _kuponController = TextEditingController();

  bool isLoading = true;

  bool isTrusted = false;

  IspravanKupon? isCouponCorrect;

  double totalPrice = 0.0;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _voznjeProvider = context.read<VoznjeProvider>();
    _korisnikProvider = context.read<KorisnikProvider>();
    _kuponiProvider = context.read<KuponiProvider>();

    totalPrice = (widget.voznja.cijena ?? 0) + 2;

    initTrusted();
  }

  Future initTrusted() async {
    var result = await _korisnikProvider.trusted(widget.voznja.vozac?.id ?? 0);

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
        child: Flexible(
          child: SingleChildScrollView(
            child: Padding(
              padding: const EdgeInsets.all(20.0),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  _buildHeader(),
                  _buildInfo(),
                  isLoading
                      ? LoadingSpinnerWidget(height: 100)
                      : _buildTrusted(),
                  _buildCouponCheck(),
                  _buildPrices(),
                  _pay()
                ],
              ),
            ),
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
                        " ${DateFormat("dd.MM.yyyy u hh:mm").format(widget.voznja.datumVrijemePocetka ?? DateTime.now())} sati",
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
              bottom: -20,
              right: 10,
              child: Icon(
                isTrusted
                    ? Icons.sentiment_satisfied_rounded
                    : Icons.sentiment_dissatisfied_rounded,
                size: 100,
                color: Colors.black.withAlpha(20),
              ),
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

  Widget _buildPrices() {
    return Container(
      margin: EdgeInsets.only(top: 20),
      child: Column(
        spacing: 12,
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          RichText(
            text: TextSpan(
                text: "Cijena:",
                children: [
                  TextSpan(
                      text: " ${widget.voznja.cijena} KM",
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
          if (isCouponCorrect?.ispravanKupon == true &&
              isCouponCorrect?.kupon != null)
            RichText(
              text: TextSpan(
                  text: "Popust na kupon:",
                  children: [
                    TextSpan(
                        text:
                            " -${(widget.voznja.cijena! - (widget.voznja.cijena! * (1 - (isCouponCorrect?.kupon?.popust ?? 0)))).toStringAsFixed(2)} KM",
                        style: TextStyle(
                            fontFamily: "Inter",
                            fontSize: 13,
                            color: Color(0xFFE14040),
                            fontWeight: FontWeight.normal))
                  ],
                  style: TextStyle(
                      fontFamily: "Inter",
                      fontSize: 13,
                      color: Colors.black,
                      fontWeight: FontWeight.bold)),
            ),
          RichText(
            text: TextSpan(
                text: "Popust na Rank:",
                children: [
                  TextSpan(
                      text: " -${widget.voznja.cijena} KM",
                      style: TextStyle(
                          fontFamily: "Inter",
                          fontSize: 13,
                          color: Color(0xFFE14040),
                          fontWeight: FontWeight.normal))
                ],
                style: TextStyle(
                    fontFamily: "Inter",
                    fontSize: 13,
                    color: Colors.black,
                    fontWeight: FontWeight.bold)),
          ),
          RichText(
            text: TextSpan(
                text: "Provizija na pronalazak:",
                children: [
                  TextSpan(
                      text: " 2.0 KM",
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
            width: double.infinity,
            height: 2,
            child: Container(
              decoration: BoxDecoration(color: Colors.black),
            ),
          ),
          RichText(
            text: TextSpan(
                text: "Ukupno:",
                children: [
                  TextSpan(
                      text: " ${totalPrice} KM",
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
        ],
      ),
    );
  }

  Widget _pay() {
    return Container(
      margin: EdgeInsets.only(top: 20),
      child: CustomButtonWidget(
        buttonText: "Plati vožnju",
        onPress: () {},
        fontSize: 12,
      ),
    );
  }

  Widget _buildCouponCheck() {
    return Container(
      margin: EdgeInsets.only(top: 20),
      constraints: BoxConstraints(maxWidth: double.infinity),
      child: SizedBox(
        child: Column(
          children: [
            SizedBox(
              height: 30,
              child: Row(
                children: [
                  Expanded(
                    // Ograničava širinu unutar Row
                    child: CustomInputField(
                      labelText: "Kupon",
                      fontSize: 10,
                      controller: _kuponController,
                    ),
                  ),
                  SizedBox(width: 10), // Razmak između inputa i dugmeta
                  SizedBox(
                    width: 100,
                    child: CustomButtonWidget(
                      buttonText: "Provjeri",
                      onPress: () async {
                        isCouponCorrect =
                            await _kuponiProvider.check(_kuponController.text);

                        if (isCouponCorrect?.kupon != null) {
                          totalPrice = totalPrice -
                              (widget.voznja.cijena! -
                                  (widget.voznja.cijena! *
                                      (1 -
                                          (isCouponCorrect?.kupon?.popust ??
                                              0))));
                        } else {
                          totalPrice = widget.voznja.cijena! + 2;
                        }

                        setState(() {});
                      },
                      fontSize: 12,
                    ),
                  ),
                ],
              ),
            ),
            _kuponController.text.isNotEmpty && isCouponCorrect != null
                ? Container(
                    alignment: Alignment.centerLeft,
                    child: Text(
                      isCouponCorrect!.ispravanKupon
                          ? "Kupon je uredan."
                          : "Kupon nije uredan.",
                      style: TextStyle(fontSize: 12),
                    ),
                  )
                : Container()
          ],
        ),
      ),
    );
  }

  TextStyle _buildTextStyle() {
    return TextStyle(
        fontFamily: "Inter",
        fontSize: 30,
        color: Color(0xFF7463DE),
        fontWeight: FontWeight.w900);
  }
}
