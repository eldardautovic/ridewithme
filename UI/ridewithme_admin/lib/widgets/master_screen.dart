import 'package:flutter/material.dart';
import 'package:flutter_side_menu/flutter_side_menu.dart';
import 'package:ridewithme_admin/main.dart';
import 'package:ridewithme_admin/screens/voznje_details_screen.dart';
import 'package:ridewithme_admin/utils/util.dart';

import '../screens/voznje_list_screen.dart';

class MasterScreenWidget extends StatefulWidget {
  Widget? child;
  String? title;
  MasterScreenWidget({this.child, this.title, super.key});

  @override
  State<MasterScreenWidget> createState() => _MasterScreenWidgetState();
}

class _MasterScreenWidgetState extends State<MasterScreenWidget> {
  int? selectedItem;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: Row(
      children: [
        Padding(
          padding: EdgeInsets.all(20),
          child: Container(
              clipBehavior: Clip.hardEdge,
              decoration:
                  BoxDecoration(borderRadius: BorderRadius.circular(20)),
              child: SideMenu(
                mode: SideMenuMode.open,
                backgroundColor: Color(0xFFDFF2F0),
                hasResizer: false,
                hasResizerToggle: false,
                builder: (data) => SideMenuData(
                  header: Padding(
                      padding: EdgeInsets.all(10),
                      child: Row(
                        children: [
                          Icon(
                            Icons.account_circle,
                            size: 30,
                            color: Color(0xFF7463DE),
                          ),
                          Padding(
                            padding: EdgeInsets.only(left: 10),
                            child: Container(
                              width:
                                  120, // Define the width to ensure overflow happens
                              child: Text(
                                "Testni Korisnikeeeeeeeeeeeeeeeee",
                                maxLines: 1,
                                overflow: TextOverflow.ellipsis,
                                style: TextStyle(
                                  color: Color(0xFF072220),
                                  fontFamily: "Inter",
                                ),
                              ),
                            ),
                          ),
                          Padding(
                              padding: EdgeInsets.only(left: 10),
                              child: PopupMenuButton<int>(
                                tooltip: "Prikaži meni",
                                iconColor: Color(0xFF7463DE),
                                initialValue: selectedItem,
                                onSelected: (int item) {
                                  setState(() {
                                    selectedItem = item;
                                  });
                                },
                                itemBuilder: (BuildContext context) =>
                                    <PopupMenuEntry<int>>[
                                  PopupMenuItem<int>(
                                      value: 1,
                                      child: const Text('Odjavi se'),
                                      onTap: () {
                                        Authorization.password = null;
                                        Authorization.username = null;

                                        Navigator.of(context).push(
                                          MaterialPageRoute(
                                            builder: (context) => LoginPage(),
                                          ),
                                        );

                                        ScaffoldMessenger.of(context)
                                            .showSnackBar(
                                          SnackBar(
                                            behavior: SnackBarBehavior.floating,
                                            content: Text(
                                                "Uspješno ste se odjavili."),
                                            action: SnackBarAction(
                                                label: "U redu",
                                                onPressed: () =>
                                                    ScaffoldMessenger.of(
                                                        context)
                                                      ..removeCurrentSnackBar()),
                                          ),
                                        );
                                      })
                                ],
                              )),
                        ],
                      )),
                  items: [
                    SideMenuItemDataTile(
                      isSelected: true,
                      hasSelectedLine: false,
                      highlightSelectedColor: Color(0x268E9EE6),
                      selectedTitleStyle:
                          TextStyle(fontWeight: FontWeight.w500),
                      onTap: () {},
                      title: 'Pregled',
                      titleStyle: TextStyle(color: Color(0xFF072220)),
                      icon: const Icon(
                        Icons.home_rounded,
                        color: Color(0xFF7463DE),
                      ),
                    ),
                    SideMenuItemDataTile(
                      isSelected: false,
                      hasSelectedLine: false,
                      highlightSelectedColor: Color(0x268E9EE6),
                      onTap: () {},
                      title: 'Analitika',
                      titleStyle: TextStyle(color: Color(0xFF072220)),
                      icon: const Icon(
                        Icons.pie_chart_rounded,
                        color: Color(0xFF7463DE),
                      ),
                    ),
                    SideMenuItemDataTile(
                      isSelected: false,
                      hasSelectedLine: false,
                      highlightSelectedColor: Color(0x268E9EE6),
                      onTap: () {},
                      title: 'Korisnici',
                      titleStyle: TextStyle(color: Color(0xFF072220)),
                      icon: const Icon(
                        Icons.perm_contact_cal_rounded,
                        color: Color(0xFF7463DE),
                      ),
                    ),
                    SideMenuItemDataTile(
                      isSelected: false,
                      hasSelectedLine: false,
                      highlightSelectedColor: Color(0x268E9EE6),
                      onTap: () {},
                      title: 'Vožnje',
                      titleStyle: TextStyle(color: Color(0xFF072220)),
                      icon: const Icon(
                        Icons.directions_car_filled_rounded,
                        color: Color(0xFF7463DE),
                      ),
                    ),
                    SideMenuItemDataTile(
                      isSelected: false,
                      hasSelectedLine: false,
                      highlightSelectedColor: Color(0x268E9EE6),
                      onTap: () {},
                      title: 'Kuponi',
                      titleStyle: TextStyle(color: Color(0xFF072220)),
                      icon: const Icon(
                        Icons.confirmation_num_rounded,
                        color: Color(0xFF7463DE),
                      ),
                    ),
                    SideMenuItemDataTile(
                      isSelected: false,
                      hasSelectedLine: false,
                      highlightSelectedColor: Color(0x268E9EE6),
                      onTap: () {},
                      title: 'Žalbe',
                      titleStyle: TextStyle(color: Color(0xFF072220)),
                      icon: const Icon(
                        Icons.support_rounded,
                        color: Color(0xFF7463DE),
                      ),
                    ),
                    SideMenuItemDataTile(
                      isSelected: false,
                      hasSelectedLine: false,
                      highlightSelectedColor: Color(0x268E9EE6),
                      onTap: () {},
                      title: 'Reklame',
                      titleStyle: TextStyle(color: Color(0xFF072220)),
                      icon: const Icon(
                        Icons.backup_table_rounded,
                        color: Color(0xFF7463DE),
                      ),
                    ),
                  ],
                ),
              )),
        ),
        Column(children: [
          Padding(
              padding: EdgeInsets.all(20),
              child: Container(
                child: widget!.child,
              ))
        ]),
      ],
    ));
  }
}
