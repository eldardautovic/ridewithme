import 'package:ridewithme_admin/models/kupon.dart';
import 'package:ridewithme_admin/providers/base_provider.dart';

class KuponiProvider extends BaseProvider<Kupon> {
  KuponiProvider() : super("Kuponi");

  @override
  fromJson(data) {
    // TODO: implement fromJson
    return Kupon.fromJson(data);
  }
}
