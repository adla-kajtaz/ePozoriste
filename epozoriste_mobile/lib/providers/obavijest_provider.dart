import 'dart:io';

import 'package:epozoriste_mobile/providers/base_provider.dart';
import 'package:http/io_client.dart';

import '../models/models.dart';

class ObavijestProvider extends BaseProvider<Obavijest> {
  HttpClient client = HttpClient();
  IOClient? http;
  ObavijestProvider() : super("Obavijest");
  @override
  Obavijest fromJson(data) {
    return Obavijest.fromJson(data);
  }
}
