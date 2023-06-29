import 'package:json_annotation/json_annotation.dart';

part 'korisnik.g.dart';

@JsonSerializable()
class Korisnik {
  int? korisnikId;
  String? ime;
  String? prezime;
  String? korisnickoIme;
  String? email;
  String? brTelefona;
  String? lozinka;
  String? lozinkaProvjera;

  Korisnik({
    this.korisnikId,
    this.ime,
    this.prezime,
    this.korisnickoIme,
    this.email,
    this.brTelefona,
    this.lozinka,
    this.lozinkaProvjera
  });

  factory Korisnik.fromJson(Map<String, dynamic> json) => _$KorisnikFromJson(json);
  Map<String, dynamic> toJson() => _$KorisnikToJson(this);

}