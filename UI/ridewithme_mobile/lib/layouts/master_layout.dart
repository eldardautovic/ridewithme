import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:ridewithme_mobile/screens/home_screen.dart';
import 'package:ridewithme_mobile/screens/voznje_screen.dart';

class MasterLayout extends StatefulWidget {
  final Widget child;
  final int selectedIndex;
  String? header;
  String? headerDescription;
  Color? headerColor;
  MasterLayout(
      {super.key,
      required this.child,
      required this.selectedIndex,
      this.header,
      this.headerDescription,
      this.headerColor});

  @override
  State<MasterLayout> createState() => _MasterLayoutState();
}

class _MasterLayoutState extends State<MasterLayout> {
  final List<Map<String, dynamic>> menuItems = [
    {'title': 'Početna', 'icon': Icons.home_rounded, 'route': HomeScreen()},
    {
      'title': 'Vožnje',
      'icon': Icons.directions_car_filled_rounded,
      'route': VoznjeScreen()
    },
    {'title': '', 'icon': Icons.add_circle, 'route': HomeScreen(), 'size': 50},
    {'title': 'Ocjene', 'icon': Icons.star_rate_rounded, 'route': HomeScreen()},
    {'title': 'Profil', 'icon': Icons.person_2_rounded, 'route': HomeScreen()},
  ];

  void _onItemTapped(int index) {
    Navigator.of(context).push(
      PageRouteBuilder(
        pageBuilder: (context, animation1, animation2) =>
            menuItems[index]['route'] as Widget,
        transitionDuration: Duration.zero,
        reverseTransitionDuration: Duration.zero,
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return PopScope(
      canPop: false,
      child: Scaffold(
          body: Column(
            spacing: 10,
            children: [
              if (widget.header != null &&
                  widget.headerDescription != null &&
                  widget.headerColor != null)
                Container(
                  margin: EdgeInsets.all(20),
                  decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(15),
                      color: widget.headerColor?.withAlpha(60)),
                  alignment: Alignment.centerLeft,
                  child: Padding(
                    padding: const EdgeInsets.all(20.0),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(widget.header ?? '',
                            style: TextStyle(
                                fontFamily: "Inter",
                                fontSize: 20,
                                fontWeight: FontWeight.bold,
                                color: widget.headerColor),
                            overflow: TextOverflow.ellipsis),
                        Text(widget.headerDescription ?? '',
                            style: TextStyle(
                                fontFamily: "Inter",
                                fontSize: 13,
                                fontWeight: FontWeight.normal,
                                color: Color(0xFF072220)),
                            overflow: TextOverflow.ellipsis),
                      ],
                    ),
                  ),
                ),
              widget.child
            ],
          ),
          bottomNavigationBar: CupertinoTabBar(
            items: menuItems
                .map((e) => BottomNavigationBarItem(
                      icon: Icon(
                        e['icon'],
                        size: e['title'] == "" ? 45 : 30,
                      ),
                      activeIcon: Icon(
                        e['icon'],
                        color: Color(0xFF7463DE),
                        size: e['title'] == "" ? 45 : 30,
                      ),
                      label: e['title'],
                    ))
                .toList(),
            inactiveColor: Color(0xFF848388),
            currentIndex: widget.selectedIndex,
            onTap: (value) => _onItemTapped(value),
            activeColor: Color(0xFF000000),
          ),
          endDrawer: Drawer(
              child: ListView(
            padding: EdgeInsets.zero,
            children: [
              DrawerHeader(
                decoration: BoxDecoration(color: Colors.blue),
                child: Text("Filteri pretrage"),
              ),
              ListTile(
                title: Text("Opcija 1"),
                onTap: () {},
              ),
            ],
          ))),
    );
  }
}
