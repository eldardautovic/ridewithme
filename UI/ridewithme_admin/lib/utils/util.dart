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
  Activate("Aktiviraj", Colors.green), // Zelena za aktivaciju
  Hide("Sakrij", Colors.orange), // Narandžasta za sakrivanje
  Delete("Obriši", Colors.red), // Crvena za brisanje
  Edit("Uredi", Colors.blue), // Plava za uređivanje
  NonExisting("", Colors.transparent); // Transparentna za nepostojeće akcije

  final String naziv;
  final Color boja;
  const VoznjaActions(this.naziv, this.boja);

  static VoznjaActions? fromString(String? value) {
    return VoznjaActions.values.firstWhere(
      (status) => status.name == value,
      orElse: () => VoznjaActions.NonExisting,
    );
  }
}
