import 'dart:convert';

import 'package:ridewithme_mobile/models/chat_message.dart';
import 'package:ridewithme_mobile/providers/base_provider.dart';

import 'package:http/http.dart' as http;

class ChatProvider extends BaseProvider<ChatMessage> {
  ChatProvider() : super("Chat");

  Future<List<ChatMessage>> conversation(int recieverId, int senderId) async {
    var url = "$fullUrl/$recieverId/conversation/$senderId";

    var uri = Uri.parse(url);
    var headers = createHeaders();

    var response = await http.get(uri, headers: headers);

    if (isValidResponse(response)) {
      var data = jsonDecode(response.body);

      List<ChatMessage> result = [];

      for (var item in data) {
        result.add(fromJson(item));
      }

      return result;
    } else {
      throw new Exception("Unknown error");
    }
  }

  @override
  fromJson(data) {
    // TODO: implement fromJson
    return ChatMessage.fromJson(data);
  }
}
