import 'dart:convert';

import 'package:http/http.dart' as http;
import 'package:ridewithme_mobile/models/korisnik.dart';
import 'package:ridewithme_mobile/providers/base_provider.dart';

class KorisnikProvider extends BaseProvider<Korisnik> {
  KorisnikProvider() : super("Korisnici");

  @override
  fromJson(data) {
    // TODO: implement fromJson
    return Korisnik.fromJson(data);
  }

  Future<Korisnik> login(String username, String password) async {
    var url = "$fullUrl/login?username=${username}&password=${password}";

    var uri = Uri.parse(url);
    var headers = createHeaders();

    var response = await http.post(uri, headers: headers);

    if (isValidResponse(response)) {
      var data = jsonDecode(response.body);

      return fromJson(data);
    } else {
      throw new Exception("Unknown error");
    }
  }

  Future<int> trusted(int id) async {
    var url = "$fullUrl/${id}/trusted";

    var uri = Uri.parse(url);
    var headers = createHeaders();

    var response = await http.get(uri, headers: headers);

    if (isValidResponse(response)) {
      var data = jsonDecode(response.body);

      return data['brojZavrsenihVoznji'];
    } else {
      throw new Exception("Unknown error");
    }
  }

  Future<List<Korisnik>> popular() async {
    var url = "$fullUrl/popular";

    var uri = Uri.parse(url);
    var headers = createHeaders();

    var response = await http.get(uri, headers: headers);

    if (isValidResponse(response)) {
      var data = jsonDecode(response.body);

      List<Korisnik> result = [];

      for (var item in data) {
        result.add(fromJson(item));
      }

      return result;
    } else {
      throw new Exception("Unknown error");
    }
  }
}
