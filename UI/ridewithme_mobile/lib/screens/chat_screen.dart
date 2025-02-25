import 'dart:developer';

import 'package:dart_amqp/dart_amqp.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_mobile/layouts/master_layout.dart';
import 'package:ridewithme_mobile/models/chat_message.dart';
import 'package:ridewithme_mobile/providers/chat_provider.dart';
import 'package:ridewithme_mobile/utils/auth_util.dart';
import 'package:ridewithme_mobile/widgets/chat_bubble.dart';
import 'package:ridewithme_mobile/widgets/loading_spinner_widget.dart';

class ChatScreen extends StatefulWidget {
  int senderId;
  ChatScreen({super.key, required this.senderId});

  @override
  State<ChatScreen> createState() => _ChatScreenState();
}

class _ChatScreenState extends State<ChatScreen> {
  late ChatProvider _chatProvider;
  final TextEditingController _messageController = TextEditingController();
  List<ChatMessage>? _messages;

  bool isLoading = true;

  Client client = Client(
      settings: ConnectionSettings(
          host:
              const String.fromEnvironment("mqHost", defaultValue: "localhost"),
          authProvider: const PlainAuthenticator(
              String.fromEnvironment("mqUsername", defaultValue: "user"),
              String.fromEnvironment("mqPass", defaultValue: "mypass"))));

  @override
  void initState() {
    super.initState();
    _chatProvider = context.read<ChatProvider>();
    initChat();

    checkNotifications();
  }

  Future initChat() async {
    _messages = await _chatProvider.conversation(
      Authorization.id ?? 0,
      widget.senderId,
    );

    setState(() {
      isLoading = false;
    });
  }

  Future<void> checkNotifications() async {
    Channel channel = await client.channel();

    Queue queue = await channel.queue("chat");

    var consumer = await queue.consume();

    consumer.listen((AmqpMessage message) {
      if (message.payloadAsJson["RecieverId"] == Authorization.id ||
          message.payloadAsJson["SenderId"] == Authorization.id) {
        isLoading = true;

        initChat();
      }
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterLayout(
        selectedIndex: 4,
        child: Flexible(
          child: SingleChildScrollView(
            child: Column(
              children: [
                isLoading ? LoadingSpinnerWidget(height: 500) : _buildChat()
              ],
            ),
          ),
        ));
  }

  Widget _buildChat() {
    return Container(
      margin: EdgeInsets.all(20),
      width: double.infinity,
      child: Column(
          spacing: 10,
          children: _messages?.map((element) {
                log("${element.reciever?.id}");
                return Row(
                  mainAxisAlignment: element.reciever?.id == Authorization.id
                      ? MainAxisAlignment.end // Poravnanje desno
                      : MainAxisAlignment.start, // Poravnanje lijevo
                  children: [
                    ChatBubble(poruka: element),
                  ],
                );
              }).toList() ??
              []),
    );
  }
}
