// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'voznja.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Voznja _$VoznjaFromJson(Map<String, dynamic> json) => Voznja()
  ..id = (json['id'] as num?)?.toInt()
  ..stateMachine = json['stateMachine'] as String?;

Map<String, dynamic> _$VoznjaToJson(Voznja instance) => <String, dynamic>{
      'id': instance.id,
      'stateMachine': instance.stateMachine,
    };
