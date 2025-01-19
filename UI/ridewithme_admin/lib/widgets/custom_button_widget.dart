import 'package:flutter/material.dart';

class CustomButtonWidget extends StatelessWidget {
  CustomButtonWidget({required this.buttonText, required this.onPress});

  final void Function()? onPress;
  final String buttonText;

  @override
  Widget build(BuildContext context) {
    return ElevatedButton(
      onPressed: onPress,
      style: ElevatedButton.styleFrom(
          foregroundColor: Color(0xFF072220),
          backgroundColor: Color(0xFF39D5C3),
          shadowColor: Colors.transparent,
          textStyle: TextStyle(fontSize: 16, fontWeight: FontWeight.w500),
          minimumSize: Size.fromHeight(40),
          padding: EdgeInsets.only(top: 16, bottom: 16),
          shape:
              RoundedRectangleBorder(borderRadius: BorderRadius.circular(5))),
      child: Text(
        buttonText,
        style: TextStyle(fontFamily: "Inter"),
      ),
    );
  }
}
