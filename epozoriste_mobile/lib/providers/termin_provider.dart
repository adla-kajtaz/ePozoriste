import 'package:epozoriste_mobile/providers/base_provider.dart';
import '../models/models.dart';

class TerminProvider extends BaseProvider<Termin> {
  static String? _baseUrl;
  TerminProvider() : super("Termin") {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://10.0.2.2:5192/");
  }

  @override
  Termin fromJson(data) {
    return Termin.fromJson(data);
  }
}
