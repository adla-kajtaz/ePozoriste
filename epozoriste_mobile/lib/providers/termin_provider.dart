import 'dart:io';

import 'package:epozoriste_mobile/providers/base_provider.dart';
import 'package:http/io_client.dart';

import '../models/models.dart';

class TerminProvider extends BaseProvider<Termin> {
  HttpClient client = HttpClient();
  IOClient? http;
  TerminProvider() : super("Termin");
  @override
  Termin fromJson(data) {
    return Termin.fromJson(data);
  }
}
