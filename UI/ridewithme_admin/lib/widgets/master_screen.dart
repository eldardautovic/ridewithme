import 'package:flutter/material.dart';
import 'package:flutter_side_menu/flutter_side_menu.dart';
import 'package:ridewithme_admin/main.dart';
import 'package:ridewithme_admin/screens/home_screen.dart';
import 'package:ridewithme_admin/screens/voznje_list_screen.dart';
import 'package:ridewithme_admin/utils/util.dart';

class MasterScreenWidget extends StatefulWidget {
  final Widget? child;
  final int selectedIndex;
  final String? headerTitle;
  final String? headerDescription;

  MasterScreenWidget({
    this.child,
    super.key,
    required this.selectedIndex,
    this.headerTitle,
    this.headerDescription,
  });

  @override
  State<MasterScreenWidget> createState() => _MasterScreenWidgetState();
}

class _MasterScreenWidgetState extends State<MasterScreenWidget> {
  int? selectedItem;

  final List<Map<String, dynamic>> menuItems = [
    {'title': 'Pregled', 'icon': Icons.home_rounded, 'route': HomeScreen()},
    {
      'title': 'Analitika',
      'icon': Icons.pie_chart_rounded,
      'route': VoznjeListScreen()
    },
    {
      'title': 'Korisnici',
      'icon': Icons.perm_contact_cal_rounded,
      'route': VoznjeListScreen()
    },
    {
      'title': 'Vožnje',
      'icon': Icons.directions_car_filled_rounded,
      'route': VoznjeListScreen()
    },
    {
      'title': 'Kuponi',
      'icon': Icons.confirmation_num_rounded,
      'route': VoznjeListScreen()
    },
    {
      'title': 'Žalbe',
      'icon': Icons.support_rounded,
      'route': VoznjeListScreen()
    },
    {
      'title': 'Reklame',
      'icon': Icons.backup_table_rounded,
      'route': VoznjeListScreen()
    },
  ];

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
                              width: 120,
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
                  items: menuItems.map((item) {
                    final isSelected = menuItems.indexOf(item) ==
                        widget.selectedIndex; // Highlight selected item
                    return SideMenuItemDataTile(
                      isSelected: isSelected,
                      hasSelectedLine: false,
                      highlightSelectedColor: Color(0x268E9EE6),
                      selectedTitleStyle:
                          TextStyle(fontWeight: FontWeight.w500),
                      onTap: () {
                        Navigator.of(context).pushReplacement(
                          PageRouteBuilder(
                            pageBuilder: (_, __, ___) => item['route'],
                            transitionDuration: Duration(milliseconds: 200),
                            transitionsBuilder: (context, animation,
                                    secondaryAnimation, child) =>
                                FadeTransition(
                              opacity: Tween<double>(begin: 0.0, end: 1.0)
                                  .animate(animation),
                              child: child,
                            ),
                          ),
                        );
                      },
                      title: item['title'],
                      titleStyle: TextStyle(color: Color(0xFF072220)),
                      icon: Icon(
                        item['icon'],
                        color: Color(0xFF7463DE),
                      ),
                    );
                  }).toList(),
                ),
              )),
        ),
        Expanded(
          child: Padding(
            padding: EdgeInsets.all(20),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                if (widget.headerDescription != null &&
                    widget.headerTitle != null)
                  // Header with title and description
                  Padding(
                    padding: const EdgeInsets.only(bottom: 20),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        if (widget.headerTitle != null)
                          Text(
                            widget.headerTitle ?? '',
                            style: TextStyle(
                              fontSize: 24,
                              fontFamily: "Inter",
                              fontWeight: FontWeight.w800,
                              color: Color(0xFF7463DE),
                            ),
                          ),
                        if (widget.headerTitle != null) SizedBox(height: 4),
                        if (widget.headerDescription != null)
                          Text(
                            widget.headerDescription ?? '',
                            style: TextStyle(
                              fontSize: 16,
                              fontFamily: "Inter",
                              color: Color(0xFF072220),
                            ),
                          )
                      ],
                    ),
                  ),
                // Main child content
                Expanded(
                  child: Container(
                    child: widget.child,
                  ),
                ),
              ],
            ),
          ),
        ),
      ],
    ));
  }
}
