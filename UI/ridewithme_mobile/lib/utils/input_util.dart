import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';

Widget buildDropdown(
    {required String name,
    required String labelText,
    required List<DropdownMenuItem> items,
    String? initialValue,
    VoidCallback? onClear,
    bool enabled = true,
    Icon? prefixIcon,
    String? hintText}) {
  return FormBuilderDropdown(
    enabled: enabled,
    name: name,
    decoration: InputDecoration(
      prefixIcon: prefixIcon,
      labelStyle: TextStyle(fontSize: 14, fontFamily: "Inter"),
      filled: true,
      fillColor: Color(0xFFF3FCFC),
      border: OutlineInputBorder(
        borderSide: BorderSide(color: Color(0xFFE3E3E3)),
      ),
      enabledBorder: OutlineInputBorder(
        borderSide: BorderSide(color: Color(0xFFE3E3E3)),
      ),
      contentPadding: const EdgeInsets.only(left: 5, bottom: 10),
      labelText: labelText,
      hintText: hintText,
      suffix: onClear != null
          ? IconButton(
              icon: const Icon(Icons.close),
              onPressed: onClear,
            )
          : null,
    ),
    initialValue: initialValue,
    items: items,
  );
}
