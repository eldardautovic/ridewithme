import 'dart:convert';

import 'package:ridewithme_mobile/models/voznja.dart';
import 'package:ridewithme_mobile/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class VoznjeProvider extends BaseProvider<Voznja> {
  VoznjeProvider() : super("Voznje");

  Future<Voznja> book(int id, dynamic request) async {
    var url = "$fullUrl/$id/book";
    var uri = Uri.parse(url);
    var headers = createHeaders();

    var jsonRequest = jsonEncode(request);

    var response = await http.put(uri, headers: headers, body: jsonRequest);

    if (isValidResponse(response)) {
      var data = jsonDecode(response.body);
      return fromJson(data);
    } else {
      throw new Exception("Unknown error");
    }
  }

  @override
  fromJson(data) {
    // TODO: implement fromJson
    return Voznja.fromJson(data);
  }
}
