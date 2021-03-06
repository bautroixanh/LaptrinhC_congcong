public class DictionaryCommandline extends DictionaryManagement{

    // hien thi ket qua tu danh sach tu dien
    public void showAllWords(){
        System.out.printf("%-5s|%-20s|%-20s", "NO", "English", "Vietnamese" );
        System.out.println();
        for(int i = 0; i < word.size(); i++){
            System.out.printf("%-5s|%-20s|%-20s\n", i+1, word.get(i).getWord_target(), word.get(i).getWord_explain());
        }
    }
    public void dictionaryBasic(){
        insertFromCommandline();
        showAllWords();
    }
    public void dictionaryAdvanced(){
        insertFromFile();
        showAllWords();
        dictionaryLookup();
    }
    
    // tim kiem cac tu theo tu khoa
    public void dictionarySearcher() {
    	System.out.println("Nhap tu tieng anh can tim:");
    	String str = sc.next();
    	int dem = 0;
    	for(int i = 0; i < word.size(); i++) {
    		if(word.get(i).getWord_target().substring(0, str.length()).equals(str)) {
    			System.out.print(dem + 1 + "\t");
    			word.get(i).displayWord();
    			dem++;
    		}
    	}
    	if(dem == 0) {
    		System.out.println("Khong co tu can tim.");
    	}
    }
}