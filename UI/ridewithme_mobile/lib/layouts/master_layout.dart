import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:ridewithme_mobile/screens/home_screen.dart';

class MasterLayout extends StatefulWidget {
  Widget? child;
  final int selectedIndex;
  MasterLayout({super.key, this.child, required this.selectedIndex});

  @override
  State<MasterLayout> createState() => _MasterLayoutState();
}

class _MasterLayoutState extends State<MasterLayout> {
  final List<Map<String, dynamic>> menuItems = [
    {'title': 'Početna', 'icon': Icons.home_rounded, 'route': HomeScreen()},
    {
      'title': 'Vožnje',
      'icon': Icons.directions_car_filled_rounded,
      'route': HomeScreen()
    },
    {'title': '', 'icon': Icons.add_circle, 'route': HomeScreen(), 'size': 50},
    {'title': 'Ocjene', 'icon': Icons.star_rate_rounded, 'route': HomeScreen()},
    {'title': 'Profil', 'icon': Icons.person_2_rounded, 'route': HomeScreen()},
  ];

  void _onItemTapped(int index) {
    Navigator.of(context).push(CupertinoPageRoute(
      builder: (context) => menuItems[index]['route'] as Widget,
    ));
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Padding(
        padding: const EdgeInsets.only(top: 30, left: 10, right: 10),
        child: widget.child,
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
    );
  }
}
