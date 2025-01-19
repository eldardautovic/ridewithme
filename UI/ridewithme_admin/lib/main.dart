import 'package:flutter/material.dart';
import 'package:flutter_svg/flutter_svg.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_admin/providers/voznje_provider.dart';
import 'package:ridewithme_admin/utils/util.dart';
import './screens/voznje_list_screen.dart';

void main() {
  runApp(MultiProvider(
    providers: [ChangeNotifierProvider(create: (_) => VoznjeProvider())],
    child: const MyApp(),
  ));
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Color(0xFF39D5C3)),
        useMaterial3: true,
      ),
      home: LoginPage(),
    );
  }
}

class LoginPage extends StatelessWidget {
  LoginPage({super.key});

  TextEditingController _usernameController = TextEditingController();
  TextEditingController _passwordController = TextEditingController();
  late VoznjeProvider _voznjeProvider;

  final _formKey = GlobalKey<FormState>();

  @override
  Widget build(BuildContext context) {
    _voznjeProvider = context.read<VoznjeProvider>();
    return Scaffold(
      body: Stack(
        children: [
          Positioned(
            top: 0,
            right: 0,
            child: SvgPicture.asset(
              "assets/images/logo.svg",
              width: 1000,
              height: 650,
            ),
          ),
          Positioned(
            bottom: 0,
            left: 0,
            child: SvgPicture.asset(
              "assets/images/left-border.svg",
              width: 1000,
              height: 700,
            ),
          ),
          Center(
            child: Container(
              constraints: BoxConstraints(maxHeight: 500, maxWidth: 400),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Container(
                      constraints:
                          BoxConstraints(maxHeight: 180, maxWidth: 400),
                      child: Align(
                          alignment: Alignment.topLeft,
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Text(
                                "ridewithme.",
                                style: TextStyle(
                                    fontFamily: "Inter",
                                    fontSize: 50,
                                    fontWeight: FontWeight.w900),
                              ),
                              SizedBox(
                                height: 30,
                              ),
                              Text(
                                "Dobrodošli nazad!",
                                textAlign: TextAlign.right,
                                style: TextStyle(
                                    fontFamily: "Inter",
                                    fontSize: 30,
                                    fontWeight: FontWeight.w700,
                                    color: Color(0xFF072220)),
                              ),
                              Text(
                                "Unesite korisničko ime i lozinku",
                                textAlign: TextAlign.right,
                                style: TextStyle(
                                    fontFamily: "Inter",
                                    fontSize: 15,
                                    color: Color(0xFF072220)),
                              ),
                            ],
                          ))),
                  SizedBox(height: 10),
                  Container(
                    child: Form(
                        key: _formKey,
                        child: Column(
                          mainAxisSize: MainAxisSize.min,
                          children: [
                            TextFormField(
                              validator: (value) {
                                if (value == null || value.isEmpty) {
                                  return 'Korisničko ime je obavezno';
                                }
                                return null;
                              },
                              style:
                                  TextStyle(fontSize: 15, fontFamily: "Inter"),
                              decoration: InputDecoration(
                                label: Text("Korisničko ime"),
                                labelStyle: TextStyle(
                                    fontSize: 14, fontFamily: "Inter"),
                                prefixIcon: Icon(Icons.verified_user),
                                filled: true,
                                fillColor: Color(0xFFF3FCFC),
                                border: OutlineInputBorder(
                                  borderSide:
                                      BorderSide(color: Color(0xFFE3E3E3)),
                                ),
                                enabledBorder: OutlineInputBorder(
                                  borderSide:
                                      BorderSide(color: Color(0xFFE3E3E3)),
                                ),
                              ),
                              controller: _usernameController,
                            ),
                            SizedBox(height: 20),
                            TextFormField(
                              validator: (value) {
                                if (value == null || value.isEmpty) {
                                  return 'Lozinka je obavezna';
                                }
                                return null;
                              },
                              style:
                                  TextStyle(fontSize: 15, fontFamily: "Inter"),
                              decoration: InputDecoration(
                                label: Text("Lozinka"),
                                labelStyle: TextStyle(
                                    fontSize: 14, fontFamily: "Inter"),
                                filled: true,
                                fillColor: Color(0xFFF3FCFC),
                                border: OutlineInputBorder(
                                  borderSide:
                                      BorderSide(color: Color(0xFFE3E3E3)),
                                ),
                                enabledBorder: OutlineInputBorder(
                                  borderSide:
                                      BorderSide(color: Color(0xFFE3E3E3)),
                                ),
                                prefixIcon: Icon(Icons.password_rounded),
                              ),
                              controller: _passwordController,
                              obscureText: true,
                            ),
                            SizedBox(height: 30),
                            ElevatedButton(
                              style: ElevatedButton.styleFrom(
                                  foregroundColor: Color(0xFF072220),
                                  backgroundColor: Color(0xFF39D5C3),
                                  shadowColor: Colors.transparent,
                                  textStyle: TextStyle(
                                      fontSize: 16,
                                      fontWeight: FontWeight.w500),
                                  minimumSize: Size.fromHeight(40),
                                  padding: EdgeInsets.only(top: 16, bottom: 16),
                                  shape: RoundedRectangleBorder(
                                      borderRadius: BorderRadius.circular(5))),
                              onPressed: () async {
                                if (_formKey.currentState!.validate()) {
                                  var username = _usernameController.text;
                                  var password = _passwordController.text;

                                  Authorization.username = username;
                                  Authorization.password = password;

                                  try {
                                    await _voznjeProvider.get();

                                    Navigator.of(context).push(
                                      MaterialPageRoute(
                                        builder: (context) =>
                                            const VoznjeListScreen(),
                                      ),
                                    );
                                  } on Exception catch (e) {
                                    ScaffoldMessenger.of(context).showSnackBar(
                                      SnackBar(
                                        behavior: SnackBarBehavior.floating,
                                        content: Text(e.toString()),
                                        action: SnackBarAction(
                                            label: "U redu",
                                            onPressed: () =>
                                                ScaffoldMessenger.of(context)
                                                  ..removeCurrentSnackBar()),
                                      ),
                                    );
                                  }
                                }
                              },
                              child: Text(
                                "Prijavi se",
                                style: TextStyle(fontFamily: "Inter"),
                              ),
                            ),
                          ],
                        )),
                  ),
                ],
              ),
            ),
          ),
        ],
      ),
    );
  }
}
