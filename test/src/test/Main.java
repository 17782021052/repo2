package test;

import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Data[] students = new Data[5];
        students[0] = new Data("1", "1001", "张三");
        students[1] = new Data("2", "1002", "李四");
        students[2] = new Data("3", "1003", "王五");
        students[3] = new Data("4", "1004", "周六");
        students[4] = new Data("5", "1005", "李七");

        System.out.println("学生数据:");
        for (int i = 0; i < students.length; i++) {
            System.out.println("序号为"+(i+1)+"的学生姓名是："+students[i].getName()+"      学号是："+students[i].getNum());
        }

        Scanner scanner = new Scanner(System.in);        
        System.out.print("请输入要查找学生序号:");
        String stuID = scanner.next();
        boolean flag = true;
        for (int i = 0; i < students.length; i++) {
            if(students[i].getId() .equals(stuID)){
                System.out.println("成功找到该学生数据！");
                System.out.println("学号:"+students[i].getNum()+"\t"+"姓名:"+students[i].getName());
                flag = false;
                break;
            }
        }
        if (flag){
            System.out.println("该学生数据不存在!");
        }
	}
}
