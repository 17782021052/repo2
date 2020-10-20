package test;

	import java.util.Scanner;

	public class Demo {
		private static String[] Array = { "张三", "李四", "王五", "周六", "李七", "刘八", "陈九", "郑十" };

		public static void main(String[] args) {

			System.out.println("数组中的数据有：");
			for (int i = 0; i < Array.length; i++) {
				System.out.print(Array[i] + "  ");
			}

			System.out.println("");// 换行

			Scanner input = new Scanner(System.in);
			try {

				for (int i = 0; i < 999999; i++) {
					System.out.print("请输入你要查询的序号：");
					int d1 = input.nextInt();// 从键盘输入数据
					System.out.println("你查询的序号为" + d1);
					if (d1 >= (Array.length + 1) || d1 < 0) {
						System.out.println("你所输入的序号不在数据范围内，请检查后重新输入！");
					} else {
						System.out.println("你所查询的数据是：" + Array[d1 - 1]);
					}

				}
			} catch (Exception e) {
				System.out.println("请输入整数！！！！");
			}

		}
	}