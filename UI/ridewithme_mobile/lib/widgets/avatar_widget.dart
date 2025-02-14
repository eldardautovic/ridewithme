import 'package:flutter/material.dart';
import 'package:ridewithme_mobile/models/korisnik.dart';

class AvatarWidget extends StatelessWidget {
  const AvatarWidget({super.key, required this.korisnik});

  final Korisnik korisnik;

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        ClipRRect(
            borderRadius: BorderRadius.circular(100),
            child: Container(
              width: 50,
              height: 50,
              child: Icon(
                Icons.account_circle_rounded,
                size: 50,
                color: Colors.blueGrey,
              ),
            )),
        Text(
          "${korisnik.ime ?? ''}  ${korisnik.prezime ?? ''}",
          style: TextStyle(
              fontFamily: "Inter",
              color: Colors.black,
              fontSize: 10,
              fontWeight: FontWeight.w500),
        )
      ],
    );
  }
}
