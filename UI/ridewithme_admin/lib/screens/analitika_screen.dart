import 'package:fl_chart/fl_chart.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:ridewithme_admin/models/ukupna_statistika.dart';
import 'package:ridewithme_admin/providers/statistika_provider.dart';
import 'package:ridewithme_admin/widgets/loading_spinner_widget.dart';
import 'package:ridewithme_admin/widgets/master_screen.dart';

class AnalitikaScreen extends StatefulWidget {
  const AnalitikaScreen({super.key});

  @override
  State<AnalitikaScreen> createState() => _AnalitikaScreenState();
}

class _AnalitikaScreenState extends State<AnalitikaScreen> {
  late StatistikaProvider _statistikaProvider;

  UkupnaStatistika? rezultat;

  bool isLoading = true;

  int najveciBrojVoznji = 0;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();

    _statistikaProvider = context.read<StatistikaProvider>();

    initChart();
  }

  Future initChart() async {
    rezultat = await _statistikaProvider.monthly();

    setState(() {
      isLoading = false;
      najveciBrojVoznji = rezultat?.mjesecnaStatistika
              ?.map((e) => e.brojVoznji)
              .reduce((a, b) => a! > b! ? a : b) ??
          0;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      selectedIndex: 1,
      headerTitle: "Analitika",
      headerDescription: "Ovdje možete pregledati analitiku platforme.",
      child: Column(
        children: [
          isLoading
              ? LoadingSpinnerWidget()
              : Container(
                  decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(15),
                      color: Color(0x21C3CBCA)),
                  constraints:
                      BoxConstraints(maxWidth: double.infinity, maxHeight: 350),
                  child: Padding(
                    padding: const EdgeInsets.all(10.0),
                    child: BarChart(
                      BarChartData(
                        barTouchData: barTouchData,
                        titlesData: titlesData,
                        borderData: borderData,
                        barGroups: barGroups,
                        gridData: const FlGridData(show: false),
                        alignment: BarChartAlignment.spaceAround,
                        maxY: najveciBrojVoznji.toDouble() + 10,
                      ),
                    ),
                  ),
                ),
        ],
      ),
    );
  }

  BarTouchData get barTouchData => BarTouchData(
        enabled: false,
        touchTooltipData: BarTouchTooltipData(
          getTooltipColor: (group) => Colors.transparent,
          tooltipPadding: EdgeInsets.zero,
          tooltipMargin: 8,
          getTooltipItem: (
            BarChartGroupData group,
            int groupIndex,
            BarChartRodData rod,
            int rodIndex,
          ) {
            return BarTooltipItem(
              rod.toY.round().toString(),
              const TextStyle(
                color: Color(0xFF072220),
                fontWeight: FontWeight.bold,
              ),
            );
          },
        ),
      );

  Widget getTitles(double value, TitleMeta meta) {
    final style = TextStyle(
      color: Color(0xFF072220),
      fontWeight: FontWeight.bold,
      fontSize: 14,
    );
    String text;
    switch (value.toInt()) {
      case 1:
        text = 'Jan';
        break;
      case 2:
        text = 'Feb';
        break;
      case 3:
        text = 'Mar';
        break;
      case 4:
        text = 'Apr';
        break;
      case 5:
        text = 'Maj';
        break;
      case 6:
        text = 'Jun';
        break;
      case 7:
        text = 'Jul';
        break;
      case 8:
        text = 'Aug';
        break;
      case 9:
        text = 'Sep';
        break;
      case 10:
        text = 'Okt';
        break;
      case 11:
        text = 'Nov';
        break;
      case 12:
        text = 'Dec';
        break;
      default:
        text = '';
        break;
    }
    return SideTitleWidget(
      meta: meta,
      space: 4,
      child: Text(text, style: style),
    );
  }

  FlTitlesData get titlesData => FlTitlesData(
        show: true,
        bottomTitles: AxisTitles(
          sideTitles: SideTitles(
            showTitles: true,
            reservedSize: 30,
            getTitlesWidget: getTitles,
          ),
        ),
        leftTitles: const AxisTitles(
          sideTitles: SideTitles(showTitles: false),
        ),
        topTitles: const AxisTitles(
          sideTitles: SideTitles(showTitles: false),
        ),
        rightTitles: const AxisTitles(
          sideTitles: SideTitles(showTitles: false),
        ),
      );

  FlBorderData get borderData => FlBorderData(
        show: false,
      );

  List<BarChartGroupData> get barGroups =>
      rezultat?.mjesecnaStatistika
          ?.map(
            (e) => BarChartGroupData(
              x: e.mjesec ?? 0,
              barRods: [
                BarChartRodData(
                    width: 25,
                    toY: e.brojVoznji?.toDouble() ?? 0,
                    color: Color(0xFF39D5C3))
              ],
              showingTooltipIndicators: [0],
            ),
          )
          .toList() ??
      [];
}
