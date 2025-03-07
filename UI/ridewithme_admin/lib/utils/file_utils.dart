import 'dart:io';
import 'package:path_provider/path_provider.dart';

Future<void> saveAndLaunchFile(List<int> bytes, String fileName) async {
  try {
    final directory = await getApplicationDocumentsDirectory();
    final filePath = '${directory.path}/$fileName';
    final file = File(filePath);

    await file.writeAsBytes(bytes, flush: true);
    print('File saved at: $filePath');

    if (Platform.isWindows) {
      await Process.start('explorer.exe', [filePath]);
    } else if (Platform.isLinux) {
      await Process.start('xdg-open', [filePath]);
    } else if (Platform.isMacOS) {
      await Process.start('open', [filePath]);
    }
  } catch (e) {
    // Umjesto printa, zapisujemo grešku u fajl
    final logFile = File('${Directory.systemTemp.path}/error_log.txt');
    await logFile.writeAsString('Error: $e\n', mode: FileMode.append);
  }
}
