// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'kupovina.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Kupovina _$KupovinaFromJson(Map<String, dynamic> json) => Kupovina(
      kupovinaId: json['kupovinaId'] as int,
      kolicina: json['kolicina'] as int?,
      cijena: json['cijena'] as int?,
      datumKupovine: DateTime.parse(json['datumKupovine'] as String),
      korisnikId: json['korisnikId'] as int?,
      korisnik: json['korisnik'] == null
          ? null
          : Korisnik.fromJson(json['korisnik'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$KupovinaToJson(Kupovina instance) => <String, dynamic>{
      'kupovinaId': instance.kupovinaId,
      'kolicina': instance.kolicina,
      'cijena': instance.cijena,
      'datumKupovine': instance.datumKupovine.toIso8601String(),
      'korisnikId': instance.korisnikId,
      'korisnik': instance.korisnik,
    };
