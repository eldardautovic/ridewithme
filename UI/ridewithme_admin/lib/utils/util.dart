import 'package:flutter/material.dart';

class Authorization {
  static String? username;
  static String? password;
  static String? fullName;
}

enum VoznjaStatus {
  draft("Draft", Colors.amber),
  active("Aktivan", Colors.green),
  hidden("Sakriven", Colors.grey),
  booked("Rezervisan", Colors.blue),
  inprogress("U toku", Colors.orange),
  completed("Završen", Colors.purple);

  final String naziv;
  final Color boja;
  const VoznjaStatus(this.naziv, this.boja);

  static VoznjaStatus? fromString(String? value) {
    return VoznjaStatus.values.firstWhere(
      (status) => status.name == value,
      orElse: () => VoznjaStatus.draft, // Podrazumevana vrednost
    );
  }
}
