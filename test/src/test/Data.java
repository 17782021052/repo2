package test;

import java.util.ArrayList;
import java.util.List;

public class Data {
	String id;
	String num;
	String name;
	public Data(String id, String num, String name) {
		super();
		this.num = num;
		this.id = id;
		this.name = name;
	}
	public String getNum() {
		return num;
	}
	public void setNum(String num) {
		this.num = num;
	}
	public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	@Override
	public String toString() {
		return "Data [id=" + id + ", num=" + num + ", name=" + name + "]";
	}
	
}
