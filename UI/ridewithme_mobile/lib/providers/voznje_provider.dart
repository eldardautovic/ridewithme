import 'package:ridewithme_mobile/models/voznja.dart';
import 'package:ridewithme_mobile/providers/base_provider.dart';

class VoznjeProvider extends BaseProvider<Voznja> {
  VoznjeProvider() : super("Voznje");

  @override
  fromJson(data) {
    // TODO: implement fromJson
    return Voznja.fromJson(data);
  }
}
