import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_mobile/providers/gradovi_provider.dart';
import 'package:ridewithme_mobile/providers/korisnik_provider.dart';
import 'package:ridewithme_mobile/providers/obavjestenja_provider.dart';
import 'package:ridewithme_mobile/providers/voznje_provider.dart';
import 'package:ridewithme_mobile/screens/onboarding_screen.dart';

Future<void> main() async {
  WidgetsFlutterBinding.ensureInitialized();

  runApp(MultiProvider(
    providers: [
      ChangeNotifierProvider(create: (_) => KorisnikProvider()),
      ChangeNotifierProvider(create: (_) => VoznjeProvider()),
      ChangeNotifierProvider(create: (_) => ObavjestenjaProvider()),
      ChangeNotifierProvider(create: (_) => GradoviProvider()),
    ],
    child: const RideWithMeMobile(),
  ));
}

class RideWithMeMobile extends StatelessWidget {
  const RideWithMeMobile({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'ridewithme',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Color(0xFF39D5C3)),
        useMaterial3: true,
      ),
      home: OnboardingScreen(),
    );
  }
}
