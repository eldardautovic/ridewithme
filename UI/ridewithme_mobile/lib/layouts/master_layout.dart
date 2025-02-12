import 'package:flutter/material.dart';

class MasterLayout extends StatefulWidget {
  Widget? child;
  final int selectedIndex;
  MasterLayout({super.key, this.child, required this.selectedIndex});

  @override
  State<MasterLayout> createState() => _MasterLayoutState();
}

class _MasterLayoutState extends State<MasterLayout> {
  void _onItemTapped(int index) {
    print("tapped");
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Padding(
        padding: const EdgeInsets.only(top: 30, left: 10, right: 10),
        child: widget.child,
      ),
      bottomNavigationBar: BottomNavigationBar(
        items: const <BottomNavigationBarItem>[
          BottomNavigationBarItem(
              icon: Icon(Icons.home_rounded), label: 'Početna'),
          BottomNavigationBarItem(
              icon: Icon(Icons.directions_car_filled_rounded), label: 'Vožnje'),
          BottomNavigationBarItem(
              icon: Icon(
                Icons.add_circle,
                size: 50,
              ),
              label: ''),
          BottomNavigationBarItem(
              icon: Icon(Icons.star_rate_rounded), label: 'Ocjene'),
          BottomNavigationBarItem(icon: Icon(Icons.person), label: 'Profil'),
        ],
        currentIndex: widget.selectedIndex,
        selectedItemColor: Color(0xFF7463DE),
        unselectedItemColor: Color(0xFF848388),
        unselectedLabelStyle: TextStyle(color: Color(0xFF848388)),
        type: BottomNavigationBarType.fixed,
        selectedLabelStyle: TextStyle(color: Colors.black),
        onTap: _onItemTapped,
        backgroundColor: Colors.white,
        useLegacyColorScheme: false,
        showUnselectedLabels: true,
        iconSize: 30,
      ),
    );
  }
}
