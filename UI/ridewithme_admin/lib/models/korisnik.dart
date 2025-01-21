// -- korisnik.dart --
import 'package:json_annotation/json_annotation.dart';
import 'package:ridewithme_admin/models/korisnik_uloga.dart';

part 'korisnik.g.dart';

@JsonSerializable()
class Korisnik {
  int? id;
  String? ime;
  String? prezime;
  String? korisnickoIme;
  String? email;
  List<KorisnikUloga>? korisniciUloge;
  DateTime? datumKreiranja;

  Korisnik(
    this.id,
    this.ime,
    this.prezime,
    this.korisnickoIme,
    this.email,
    this.korisniciUloge,
    this.datumKreiranja,
  );

  factory Korisnik.fromJson(Map<String, dynamic> json) =>
      _$KorisnikFromJson(json);

  Map<String, dynamic> toJson() => _$KorisnikToJson(this);
}
