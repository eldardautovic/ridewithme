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

enum VoznjaActions {
  Activate(
      "Aktiviraj", Color(0xFF4CAF50), Color(0xFF072220)), // Smaragdno zelena
  Hide("Sakrij", Color(0xFFFFC107), Color(0xFF072220)), // Zlatno žuta
  Delete("Obriši", Color(0xFFFF7043), Color(0xFF072220)), // Topla narandžasta
  Edit("Uredi", Color(0xFF64B5F6), Color(0xFF072220)), // Pastelno plava
  NonExisting("", Colors.transparent,
      Color(0xFF072220)); // Transparentna za nepostojeće akcije

  final String naziv;
  final Color boja;
  final Color textBoja;
  const VoznjaActions(this.naziv, this.boja, this.textBoja);

  static VoznjaActions? fromString(String? value) {
    return VoznjaActions.values.firstWhere(
      (status) => status.name == value,
      orElse: () => VoznjaActions.NonExisting,
    );
  }
}


enum ObavjestenjeStatus {
  draft("Draft", Colors.amber),
  active("Aktivan", Colors.green),
  hidden("Sakriven", Colors.grey),
  completed("Završen", Colors.purple);

  final String naziv;
  final Color boja;
  const ObavjestenjeStatus(this.naziv, this.boja);

  static ObavjestenjeStatus? fromString(String? value) {
    return ObavjestenjeStatus.values.firstWhere(
      (status) => status.name == value,
      orElse: () => ObavjestenjeStatus.draft, // Podrazumevana vrednost
    );
  }
}

enum ObavjestenjaActions {
  Activate(
      "Aktiviraj", Color(0xFF4CAF50), Color(0xFF072220)), // Smaragdno zelena
  Hide("Sakrij", Color(0xFFFFC107), Color(0xFF072220)), // Zlatno žuta
  Complete("Označi kao završeno", Color(0xFFFF7043),
      Color(0xFF072220)), // Topla narandžasta
  Edit("Uredi", Color(0xFF64B5F6), Color(0xFF072220)), // Pastelno plava
  NonExisting("", Colors.transparent,
      Color(0xFF072220)); // Transparentna za nepostojeće akcije

  final String naziv;
  final Color boja;
  final Color textBoja;
  const ObavjestenjaActions(this.naziv, this.boja, this.textBoja);

  static ObavjestenjaActions? fromString(String? value) {
    return ObavjestenjaActions.values.firstWhere(
      (status) => status.name == value,
      orElse: () => ObavjestenjaActions.NonExisting,
    );
  }
}
