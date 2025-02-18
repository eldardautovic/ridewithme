import 'dart:convert';

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_mobile/layouts/master_layout.dart';
import 'package:ridewithme_mobile/models/kupon_check.dart';
import 'package:ridewithme_mobile/models/voznja.dart';
import 'package:ridewithme_mobile/providers/korisnik_provider.dart';
import 'package:ridewithme_mobile/providers/kuponi_provider.dart';
import 'package:ridewithme_mobile/providers/voznje_provider.dart';
import 'package:ridewithme_mobile/screens/payment_success.dart';
import 'package:ridewithme_mobile/utils/auth_util.dart';
import 'package:ridewithme_mobile/widgets/custom_button_widget.dart';
import 'package:ridewithme_mobile/widgets/custom_input_widget.dart';
import 'package:ridewithme_mobile/widgets/loading_spinner_widget.dart';
import 'package:http/http.dart' as http;

class VoznjeDetailsScreen extends StatefulWidget {
  Voznja voznja;
  VoznjeDetailsScreen({super.key, required this.voznja});

  @override
  State<VoznjeDetailsScreen> createState() => _VoznjeDetailsScreenState();
}

class _VoznjeDetailsScreenState extends State<VoznjeDetailsScreen> {
  late KorisnikProvider _korisnikProvider;
  late VoznjeProvider _voznjeProvider;
  late KuponiProvider _kuponiProvider;

  TextEditingController _kuponController = TextEditingController();

  bool isLoading = true;

  bool isTrusted = false;
  bool isDriver = false;
  int brojVoznji = 0;

  IspravanKupon? isCouponCorrect;

  double totalPrice = 2.0;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _korisnikProvider = context.read<KorisnikProvider>();
    _kuponiProvider = context.read<KuponiProvider>();
    _voznjeProvider = context.read<VoznjeProvider>();

    totalPrice += (widget.voznja.cijena ?? 0);
    isDriver = Authorization.id == widget.voznja.vozac?.id;

    initTrusted();
  }

  Future initTrusted() async {
    var result = await _korisnikProvider.trusted(widget.voznja.vozac?.id ?? 0);

    if (result > 0) {
      isTrusted = true;
      brojVoznji = result;
    }

    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterLayout(
      selectedIndex: 1,
      child: SingleChildScrollView(
        padding: const EdgeInsets.all(20.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            _buildHeader(),
            _buildInfo(),
            if (isLoading) LoadingSpinnerWidget(height: 100),
            if (!isDriver) ...[
              _buildTrusted(),
              _buildCouponCheck(),
              _buildPrices(),
              _pay(),
            ]
          ],
        ),
      ),
    );
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
        _buildDoubleTextLabel(
            strongText: "Polazak:",
            text:
                " ${DateFormat("dd.MM.yyyy u hh:mm").format(widget.voznja.datumVrijemePocetka ?? DateTime.now())} sati"),
        SizedBox(
          height: 10,
        ),
        if (Authorization.id == widget.voznja.vozac?.id)
          _buildDoubleTextLabel(
              strongText: "Cijena:", text: " ${widget.voznja.cijena} KM"),
        SizedBox(
          height: 10,
        ),
        if (Authorization.id == widget.voznja.vozac?.id)
          Text("Vi ste vozač ove vožnje.",
              style: TextStyle(
                  fontFamily: "Inter",
                  fontSize: 13,
                  color: Colors.black,
                  fontWeight: FontWeight.bold)),
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
                        ? "Ovaj vozač ima $brojVoznji uspješnih vožnji"
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
          _buildDoubleTextLabel(
              strongText: "Cijena:", text: " ${widget.voznja.cijena} KM"),
          if (isCouponCorrect?.ispravanKupon == true &&
              isCouponCorrect?.kupon != null)
            _buildDoubleTextLabel(
                strongText: "Popust na kupon:",
                text:
                    " -${(widget.voznja.cijena! - (widget.voznja.cijena! * (1 - (isCouponCorrect?.kupon?.popust ?? 0)))).toStringAsFixed(2)} KM",
                textColor: Color(0xFFE14040)),
          _buildDoubleTextLabel(
              strongText: "Popust na Rank:",
              text: " -${widget.voznja.cijena} KM",
              textColor: Color(0xFFE14040)),
          _buildDoubleTextLabel(
              strongText: "Provizija na pronalazak:", text: " 2.0 KM"),
          SizedBox(
            width: double.infinity,
            height: 2,
            child: Container(
              decoration: BoxDecoration(color: Colors.black),
            ),
          ),
          _buildDoubleTextLabel(
              strongText: "Ukupno:", text: " ${totalPrice} KM")
        ],
      ),
    );
  }

  Widget _pay() {
    return Container(
      margin: EdgeInsets.only(top: 20),
      child: CustomButtonWidget(
        buttonText: "Plati vožnju",
        onPress: () {
          makePayment();
        },
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
                      padding: const EdgeInsets.symmetric(
                          vertical: 5, horizontal: 24),
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
                      fontSize: 10,
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

  Future<void> makePayment() async {
    try {
      var paymentIntent =
          await createPaymentIntent((totalPrice).toStringAsFixed(2), "BAM");

      await Stripe.instance.initPaymentSheet(
        paymentSheetParameters: SetupPaymentSheetParameters(
          paymentIntentClientSecret: paymentIntent['client_secret'],
          merchantDisplayName: "ridewithme",
        ),
      );

      await Stripe.instance.presentPaymentSheet();

      await _voznjeProvider.book(widget.voznja.id ?? 0, {
        "kuponId": _kuponController.text.isEmpty ? null : _kuponController.text
      });

      Navigator.of(context).pushReplacement(
        CupertinoPageRoute(
          builder: (context) => PaymentSuccess(),
        ),
      );
    } catch (e) {
      if (e is StripeException) {
        return;
      }

      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          behavior: SnackBarBehavior.floating,
          content: Text(e.toString()),
        ),
      );
    }
  }

  Future<Map<String, dynamic>> createPaymentIntent(
      String amount, String currency) async {
    try {
      String secretKey = dotenv.env["STRIPE__SECRETKEY"]!;

      final response = await http.post(
        Uri.parse("https://api.stripe.com/v1/payment_intents"),
        headers: {
          "Authorization": "Bearer $secretKey",
          "Content-Type": "application/x-www-form-urlencoded",
        },
        body: {
          "amount": ((double.parse(amount) * 100).toInt()).toString(),
          "currency": currency,
          "payment_method_types[]": "card",
        },
      );

      return json.decode(response.body);
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          behavior: SnackBarBehavior.floating,
          content: Text("Interna greška servera, pokušajte ponovo."),
        ),
      );
      throw Exception(e);
    }
  }

  TextStyle _buildTextStyle() {
    return TextStyle(
        fontFamily: "Inter",
        fontSize: 30,
        color: Color(0xFF7463DE),
        fontWeight: FontWeight.w900);
  }

  TextStyle _buildBoldTextStyle(
      {bool bold = true, Color color = Colors.black}) {
    return TextStyle(
        fontFamily: "Inter",
        fontSize: 13,
        color: color,
        fontWeight: bold ? FontWeight.bold : FontWeight.normal);
  }

  Widget _buildDoubleTextLabel(
      {String strongText = '',
      String text = '',
      Color textColor = Colors.black}) {
    return RichText(
      text: TextSpan(
          text: strongText,
          children: [
            TextSpan(
                text: " $text",
                style: _buildBoldTextStyle(bold: false, color: textColor))
          ],
          style: _buildBoldTextStyle()),
    );
  }
}
