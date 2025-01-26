import 'package:ridewithme_admin/models/statistika.dart';
import 'package:ridewithme_admin/providers/base_provider.dart';

class StatistikaProvider extends BaseProvider<Statistika> {
  StatistikaProvider() : super("Statistika");

  @override
  fromJson(data) {
    // TODO: implement fromJson
    return Statistika.fromJson(data);
  }
}
