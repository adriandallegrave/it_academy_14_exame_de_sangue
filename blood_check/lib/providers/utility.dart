class Utility {
  static Uri generateUri(String path) {
    return Uri.parse("https://localhost:7288/api/${path}");
  }
}