import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:ridewithme_mobile/models/voznja.dart';

class RideWidget extends StatelessWidget {
  const RideWidget({super.key, required this.voznja, required this.boxColor});
  final Voznja voznja;
  final Color boxColor;

  @override
  Widget build(BuildContext context) {
    return Container(
      constraints: BoxConstraints(
          minWidth: 200, minHeight: 160, maxHeight: 160, maxWidth: 200),
      decoration: BoxDecoration(
          color: boxColor.withAlpha(50),
          borderRadius: BorderRadius.circular(15)),
      child: Padding(
        padding: const EdgeInsets.all(15.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          spacing: 5,
          children: [
            Row(
              spacing: 10,
              children: [
                SizedBox(
                  height: 65,
                  width: 7,
                  child:
                      DecoratedBox(decoration: BoxDecoration(color: boxColor)),
                ),
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Text(
                      voznja.gradOd?.naziv ?? '',
                      style: _buildTextStyle(),
                    ),
                    Text(
                      "Do",
                      style: _buildTextStyle(),
                    ),
                    Text(voznja.gradDo?.naziv ?? '', style: _buildTextStyle())
                  ],
                )
              ],
            ),
            Column(
              spacing: 2,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                RichText(
                  text: TextSpan(
                      text: "Polazak:",
                      children: [
                        TextSpan(
                            text:
                                " ${DateFormat("dd.MM.yyyy u hh:mm").format(voznja.datumVrijemePocetka ?? DateTime.now())}",
                            style: TextStyle(
                                fontFamily: "Inter",
                                fontSize: 11,
                                color: Colors.black,
                                fontWeight: FontWeight.normal))
                      ],
                      style: TextStyle(
                          fontFamily: "Inter",
                          fontSize: 11,
                          color: Colors.black,
                          fontWeight: FontWeight.bold)),
                ),
                RichText(
                  text: TextSpan(
                      text: "Cijena:",
                      children: [
                        TextSpan(
                            text: " ${voznja.cijena?.toInt().toString()}0 KM",
                            style: TextStyle(
                                fontFamily: "Inter",
                                fontSize: 11,
                                color: Colors.black,
                                fontWeight: FontWeight.normal))
                      ],
                      style: TextStyle(
                          fontFamily: "Inter",
                          fontSize: 11,
                          color: Colors.black,
                          fontWeight: FontWeight.bold)),
                ),
              ],
            ),
            Row(
              children: [
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
                  "${voznja.vozac?.ime ?? ''} ${voznja.vozac?.prezime ?? ''}",
                  overflow: TextOverflow.ellipsis,
                  style: TextStyle(
                      fontFamily: "Inter",
                      fontSize: 11,
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

  TextStyle _buildTextStyle() {
    return TextStyle(
        fontFamily: "Inter",
        fontSize: 14,
        color: Colors.black,
        fontWeight: FontWeight.w500);
  }
}
