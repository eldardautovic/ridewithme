import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import 'package:ridewithme_admin/utils/util.dart';

class VoznjeProvider with ChangeNotifier {
  static String? _baseUrl;

  String _endpoint = "Voznje";

  VoznjeProvider() {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://localhost:5284/api/");
  }

  Future<dynamic> get() async {
    var url = "$_baseUrl$_endpoint";

    var uri = Uri.parse(url);

    var result = await http.get(uri, headers: createHeaders());

    if (isValidResponse(result)) {
      var data = jsonDecode(result.body);
      return data;
    } else {
      throw Exception("Nepoznata greška.");
    }
  }

  bool isValidResponse(http.Response response) {
    if (response.statusCode < 299) {
      return true;
    } else if (response.statusCode == 401) {
      throw Exception("Niste autorizovani.");
    } else {
      throw Exception("Nešto je pošlo po zlu. Pokušajte kasnije.");
    }
  }

  Map<String, String> createHeaders() {
    String username = Authorization.username ?? "";
    String password = Authorization.password ?? "";

    String basicAuth =
        "Basic ${base64Encode(utf8.encode('$username:$password'))}";

    var headers = {
      "Content-Type": "application/json",
      "Authorization": basicAuth
    };

    return headers;
  }
}
