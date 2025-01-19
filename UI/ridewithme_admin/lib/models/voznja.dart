import 'package:json_annotation/json_annotation.dart';

part 'voznja.g.dart';

@JsonSerializable()
class Voznja {
  int? id;
  String? stateMachine;

  Voznja({this.id, this.stateMachine});

  factory Voznja.fromJson(Map<String, dynamic> json) => _$VoznjaFromJson(json);

  /// Connect the generated [_$VoznjaToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$VoznjaToJson(this);
}
