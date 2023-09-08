import 'dart:io';

import 'package:epozoriste_mobile/providers/base_provider.dart';
import 'package:http/io_client.dart';

import '../models/models.dart';

class KartaProvider extends BaseProvider<Karta> {
  HttpClient client = HttpClient();
  IOClient? http;
  KartaProvider() : super("Karta");
  @override
  Karta fromJson(data) {
    return Karta.fromJson(data);
  }
}
