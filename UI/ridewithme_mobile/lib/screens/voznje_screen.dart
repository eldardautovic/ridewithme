import 'package:flutter/cupertino.dart';
import 'package:ridewithme_mobile/layouts/master_layout.dart';

class VoznjeScreen extends StatefulWidget {
  const VoznjeScreen({super.key});

  @override
  State<VoznjeScreen> createState() => _VoznjeScreenState();
}

class _VoznjeScreenState extends State<VoznjeScreen> {
  @override
  Widget build(BuildContext context) {
    return MasterLayout(
      selectedIndex: 1,
      header: "Vožnje",
      headerDescription: "Ovdje možete da pronađete vožnje ",
      headerColor: Color(0xFF7463DE),
      child: Column(
        children: [
          CupertinoSearchTextField(
            placeholder: "Pretraži vožnje...",
            decoration: BoxDecoration(
              border: Border.all(color: Color(0xFFE3E3E3), width: 1),
              color: Color(0xFFF3FCFC),
              borderRadius: BorderRadius.circular(5),
            ),
          )
        ],
      ),
    );
  }
}
