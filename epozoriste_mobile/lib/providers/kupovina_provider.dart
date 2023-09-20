import '../models/kupovina.dart';
import 'base_provider.dart';

class KupovinaProvider extends BaseProvider<Kupovina> {
  static String? _baseUrl;
  KupovinaProvider() : super("Kupovina") {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://10.0.2.2:5192/");
  }

  @override
  Kupovina fromJson(data) {
    return Kupovina.fromJson(data);
  }
}
