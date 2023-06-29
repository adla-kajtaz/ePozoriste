import '../models/korisnik.dart';
import 'base_provider.dart';

class KorisnikProvider extends BaseProvider<Korisnik> {
  Korisnik? _user;
  KorisnikProvider() : super("Korisnici");

  Korisnik? get user => _user;

  void setUser(Korisnik? user){
    _user = user;
    notifyListeners();
  }

  @override
  Korisnik fromJson(data) {
    return Korisnik.fromJson(data);
  }
}