import 'package:json_annotation/json_annotation.dart';

part 'predstava.g.dart';

@JsonSerializable()
class Predstava {
  int predstavaId;
  String naziv;
  String sadrzaj;
  String? slika;
  int vrijemeTrajanje;
  String rezija;
  String scenografija;
  String kostimografija;

  Predstava(
      {required this.predstavaId,
      required this.naziv,
      required this.sadrzaj,
      this.slika,
      required this.vrijemeTrajanje,
      required this.rezija,
      required this.scenografija,
      required this.kostimografija});

  factory Predstava.fromJson(Map<String, dynamic> json) =>
      _$PredstavaFromJson(json);
  Map<String, dynamic> toJson() => _$PredstavaToJson(this);
}
