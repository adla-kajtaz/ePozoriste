import 'package:epozoriste_mobile/models/models.dart';
import 'package:json_annotation/json_annotation.dart';

part 'karta.g.dart';

@JsonSerializable()
class Karta {
  int kartaId;
  bool aktivna;
  int brojSjedista;
  String brojReda;
  String sjediste;
  int? terminId;
  Termin termin;

  Karta(
      {required this.kartaId,
      required this.aktivna,
      required this.brojSjedista,
      required this.brojReda,
      required this.sjediste,
      this.terminId,
      required this.termin});

  factory Karta.fromJson(Map<String, dynamic> json) => _$KartaFromJson(json);
  Map<String, dynamic> toJson() => _$KartaToJson(this);
}
