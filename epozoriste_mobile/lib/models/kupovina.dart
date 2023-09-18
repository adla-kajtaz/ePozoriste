import 'package:epozoriste_mobile/models/models.dart';
import 'package:json_annotation/json_annotation.dart';

part 'kupovina.g.dart';

@JsonSerializable()
class Kupovina {
  int kupovinaId;
  int? kolicina;
  int? cijena;
  DateTime datumKupovine;
  int? korisnikId;
  Korisnik? korisnik;

  Kupovina({
    required this.kupovinaId,
    this.kolicina,
    this.cijena,
    required this.datumKupovine,
    this.korisnikId,
    this.korisnik,
  });

  factory Kupovina.fromJson(Map<String, dynamic> json) =>
      _$KupovinaFromJson(json);
  Map<String, dynamic> toJson() => _$KupovinaToJson(this);
}
