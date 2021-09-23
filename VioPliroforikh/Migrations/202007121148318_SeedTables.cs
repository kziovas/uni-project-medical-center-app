namespace VioPliroforikh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedTables : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Exams ( Name, Description,Preparation,Price,Duration) Values(N'Αιματοκρίτης',N'Καθορισμός αναλογίας του αίματος που αντιστοιχεί στα ερυθρά αιμοσφαίρια (RBCs)',N'Όχι',15,15)");
            Sql("INSERT INTO Exams ( Name, Description,Preparation,Price,Duration) Values(N'HDL Χοληστερόλη',N'Καθορισμός κίνδυνου εκδήλωσης καρδιακής νόσου',N'Νηστεία 1 ημέρας',15,10)");
            Sql("INSERT INTO Exams ( Name, Description,Preparation,Price,Duration) Values(N'Γενική Εξέταση Αίματος',N'Αξιολόγηση γενικής κατάστασης της υγείας του εξεταζόμενου, έλεγχος και παρακολούθηση μιας μεγάλης κατηγορίας παθήσεων ',N'Όχι',40,20)");
            Sql("INSERT INTO Exams ( Name, Description,Preparation,Price,Duration) Values(N'Γενική Εξέταση Ούρων',N'Ελεγχος και παρακολούθηση διάφορων ασθενειών όπως η νεφρική διαταραχή ή οι λοιμώξεις της ουροδόχου κύστης',N'Νηστεία 1 ημέρας',20,15)");
            Sql("INSERT INTO Exams ( Name, Description,Preparation,Price,Duration) Values(N'Τεστ Παπανικολάου',N'Ελεγχος έναντι του καρκίνου της μήτρας και συγκεκριμένων κολπικών λοιμώξεων ',N'Υπάρχουν οδηγίες από κρατικούς φορείς Υγείας  για το πως πρέπει οι γυναίκες να προετοιμάζονται για την συγκεκριμένη εξέταση',65,40)");
            Sql("INSERT INTO Exams ( Name, Description,Preparation,Price,Duration) Values(N'Οφθαλμολογικό Check-up',N'To Οφθαλμολογικό Check-up είναι ένας κλινικός έλεγχος της οπτικής κατάστασης ενός ατόμου',N'Οχι',50,25)");
            Sql("INSERT INTO Exams ( Name, Description,Preparation,Price,Duration) Values(N'Βιομετρία',N'Μέτρηση συγκεκριμένων διαστάσεων του οφθαλμού',N'Οχι',30,20)");
            Sql("INSERT INTO Exams ( Name, Description,Preparation,Price,Duration) Values(N'Triplex καρδιάς',N'Έγχρωμα υπερηχογραφήματα, όπου μελετάται η λειτουργία των βαλβίδων και η ροή του αίματος',N'Οχι',55,25)");
            Sql("INSERT INTO Exams ( Name, Description,Preparation,Price,Duration) Values(N'Ηλεκτροκαρδιογράφημα',N'Το ηλεκτροκαρδιογράφημα μπορεί να καταγράψει τη δραστηριότητα των μυών της παλλόμενης καρδιάς',N'Οχι',50,20)");
            Sql("INSERT INTO Exams ( Name, Description,Preparation,Price,Duration) Values(N'Τεστ κοπώσεως',N'Ο εξεταζόμενος περπατάει πάνω σε ένα κοιλιόμενο τάπητα ενω καταγράφεται συνεχώς ηλεκτροκαρδιογράφημα',N'Οχι',60,30)");



            Sql("INSERT INTO Departments ( Title, Description,Details,Logo,Image1,Image2,Phone,Email) Values(N'Βιοπαθολογικό',N'Μικροβιολογικό, Ορμονολογικό, Βιοχημικό, Αιματολογικό, Ανοσολογικό, Αλλεργιολογικό, Νεοπλασματικοί δείκτες, Επίπεδα Φαρμάκων, Ανίχνευση τοξικών ουσιών, Προγεννητικός Έλεγχος, Μοριακή Βιολογία(PCR)',N'Ο σύγχρονος εξοπλισμός του εργαστηρίου μας και η ύπαρξη εξειδικευμένων επιστημόνων επιτρέπει την εκτέλεση όλων των εξετάσεων που απαιτεί σήμερα η Ιατρική. Το εργαστήριο διαθέτει πρότυπο διαπίστευσης ΕΛΟΤ ΕΝ ISO 15189 (αρ. πρωτοκόλλου 888) από το 2013. Σκοπός μας είναι το αξιόπιστο αποτέλεσμα στο συντομότερο δυνατό χρονικό διάστημα, ώστε να αποτελέσει άριστο εργαλείο στα χέρια του κλινικού Ιατρού. Αυτό επιτυγχάνεται μέσω της υψηλής τεχνολογίας αυτοματοποίησης που μας δίνει τη δυνατότητα υψηλής παραγωγικότητας και ελαχιστοποιεί τη πιθανότητα αναλυτικού σφάλματος.','fa fa-stethoscope','~/Images/viopathologiko1.jpg','~/Images/viopathologiko2.jpg','210-30313233','viopath@vioexam.com')");
            Sql("INSERT INTO Departments ( Title, Description,Details,Logo,Image1,Image2,Phone,Email) Values(N'Κυτταρολογικό',N'Παρακέντηση και Βιοψία όζων Θυρεοειδούς FNA, ειδικό τμήμα για PAP TEST (απλό και υγρής φάσης Thin Prep)',N'Η Κυτταρολογία είναι μια ιατρική ειδικότητα που δεν θεραπεύει αλλά αναγνωρίζει γρήγορα, αποτελεσματικά και σχετικά ανέξοδα τις προκαρκινοματώδεις καταστάσεις καθώς και τον καρκίνο','fa fa-flask','~/Images/kitarologiko1.jpg','~/Images/kitarologiko2.jpg','210-30313234','kittaro@vioexam.com')");
            Sql("INSERT INTO Departments ( Title, Description,Details,Logo,Image1,Image2,Phone,Email) Values(N'Οφθαλμολογικό',N'Μέτρηση της οπτικής οξύτητας, Διάθλαστικός έλεγχος, Τονομέτρηση, Εξέταση στη σχισμοειδή λυχνία,Εξέταση με το οφθαλμοσκόπιο',N'Στη Μονάδα Ημερήσιας Νοσηλείας του Κέντρου μας χειρουργούνται καθημερινά περιστατικά που αφορούν το σύνολο των οφθαλμολογικών παθήσεων: διόθρωση μυωπίας – υπερμετρωπίας – αστιγματισμού με excimer laser, επεμβάσεις καταρράκτη, γλαυκώματος, ωχράς, αμφιβληστροειδούς, υαλοειδούς, βλεφάρων κ.α.','fa fa-eye','~/Images/ofthalmologiko1.jpg','~/Images/ofthalmologiko2.jpg','210-30313236','opto@vioexam.com')");
            Sql("INSERT INTO Departments ( Title, Description,Details,Logo,Image1,Image2,Phone,Email) Values(N'Καρδιολογικό',N'Triplex Καρδιάς, Ηλεκτροκαρδιογράφημα, Test Κοπώσεως, Holter Ρυθμού – Holter Πιέσεως',N'Το Καρδιολογικό Τμήμα υποστηρίζεται από καινοτόμα Διαγνωστικά Εργαστήρια και Μονάδες, τα οποία καλύπτουν όλο το φάσμα της καρδιολογίας με την πλέον σύγχρονη προσέγγιση.','fa fa-heartbeat','~/Images/kardiologiko1.jpg','~/Images/kardiologiko2.jpg','210-30313235','cardio@vioexam.com')");

            Sql("INSERT INTO Patients ( FirstName,LastName,DoB,Gender,Conditions,Treatments,Phone,Email) Values(N'Δημήτρης',N'Παπανικολάου',N'27/04/1980',N'Άρρεν',N'Σακχαρώδης Διαβήτης',N'Metformin','2103032450','d_pap@gmail.com')");
            Sql("INSERT INTO Patients ( FirstName,LastName,DoB,Gender,Conditions,Treatments,Phone,Email) Values(N'Νικόλας',N'Ζορμπάς',N'13/08/1971',N'Άρρεν',N'Μυωπία',N'Όχι','2104602781','n_zor@gmail.com')");
            Sql("INSERT INTO Patients ( FirstName,LastName,DoB,Gender,Conditions,Treatments,Phone,Email) Values(N'Μαρία',N'Σούτσου',N'07/11/1963',N'Θήλλυ',N'Αναιμία',N'Ferrobival ','2107269304','m_sou@gmail.com')");
            Sql("INSERT INTO Patients ( FirstName,LastName,DoB,Gender,Conditions,Treatments,Phone,Email) Values(N'Ελένη',N'Νάνου',N'21/05/1990',N'Θήλλυ',N'Όχι',N'Όχι','2102937736','e_nan@gmail.com')");
            Sql("INSERT INTO Patients ( FirstName,LastName,DoB,Gender,Conditions,Treatments,Phone,Email) Values(N'Κώστας',N'Μητροπάνου',N'30/12/1955',N'Άρρεν',N'Κολπική μαρμαρυγή',N'Pradaxa,Xarelto','2109117727','k_mit@gmail.com')");

            Sql("INSERT INTO Appointments ( Date,Comments,UID,ExamId,PatientId,Confirmed,Paid) Values(07/09/2020,N'Επαναληπτική εξέταση',07/09/2020-1-3,1,3,'TRUE','FALSE')");
            Sql("INSERT INTO Appointments ( Date,Comments,UID,ExamId,PatientId,Confirmed,Paid) Values(13/10/2020,N'Επείγουσα έκδοση αποτελεσμάτων',13/10/2020-3-1,3,1,'TRUE','FALSE')");
            Sql("INSERT INTO Appointments ( Date,Comments,UID,ExamId,PatientId,Confirmed,Paid) Values(22/10/2020,N'Προπυπάρχουσα πάθηση που πρέπει να εκτιμηθεί',22/10/2020-2-4,2,4,'FALSE','TRUE')");
            Sql("INSERT INTO Appointments ( Date,Comments,UID,ExamId,PatientId,Confirmed,Paid) Values(29/09/2020,N'Κανένα σχόλιο',29/09/2020-4-3,4,3,'TRUE','FALSE')");
            Sql("INSERT INTO Appointments ( Date,Comments,UID,ExamId,PatientId,Confirmed,Paid) Values(19/09/2020,N'Επαναληπτική εξέταση',19/09/20204-5,4,5,'TRUE','TRUE')");
            Sql("INSERT INTO Appointments ( Date,Comments,UID,ExamId,PatientId,Confirmed,Paid) Values(23/10/2020,N'Κανένα σχόλιο',23/10/2020-5-2,5,2,'TRUE','FALSE')");
            Sql("INSERT INTO Appointments ( Date,Comments,UID,ExamId,PatientId,Confirmed,Paid) Values(15/09/2020,N'Συμπληρωματική εξέταση',15/09/2020-5-4,5,4,'FALSE','FALSE')");
        }
        
        public override void Down()
        {
        }
    }
}
