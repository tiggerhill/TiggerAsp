using TiggerAsp.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TiggerAsp.Data
{
    public class PhotoDbContext : IdentityDbContext<User>
    {
        public PhotoDbContext(DbContextOptions<PhotoDbContext> options)
            : base(options)
        { }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Occasion> Occasions { get; set; }
        public DbSet<Comment> Comments { get; set; }
        //public DbSet<User> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Photo>().HasData(
new Photo { PhotoId = 1, FileName = "EH-001.jpg", OccasionId = "EH", Description = "Elisha and Orpha (Hazlett) Hendrix Family. Taken in 1934 at their home in Davis City, Iowa. Left - back row, Ed, Chet, and Bill. Middle, Elisah, Jessie and Ruby; Front, Jim and Oliver." },
new Photo { PhotoId = 2, FileName = "EH-002.jpg", OccasionId = "EH", Description = "Bill, Ed, Chet and Elisha Hendrix. All three are sons of Elisha. Taken at their home in Davis City, IA in 1936" },
new Photo { PhotoId = 3, FileName = "EH-003.jpg", OccasionId = "EH", Description = "The first one on the left is Oliver. He is very young here!" },
new Photo { PhotoId = 4, FileName = "EH-004.jpg", OccasionId = "EH", Description = "Oliver on left, Chet, Jessie, Ed, Bill, Jim and Ruby (not in picture) are all children of Elisha and Orpha (Hazlett) Hendrix!, taken fall of 1944." },
new Photo { PhotoId = 5, FileName = "EH-005.jpg", OccasionId = "EH", Description = "Oliver and Jim, sons of Elisha and Orpha (Hazlett) Hendrix. Taken in 1944 on Chet and Mildred (Baughman) Hendrix's farm at Leon, Iowa." },
new Photo { PhotoId = 6, FileName = "EH-006.jpg", OccasionId = "EH", Description = "Elisha and Orpha (Hazlett) Hendrix's sons. Chet standing on top of hay, Ed on left and Oliver, putting up hay on Chet's farm at Leon, Iowa in 1943." },
new Photo { PhotoId = 7, FileName = "EH-007.jpg", OccasionId = "EH", Description = "Elisha and Orpha (Hazlett) Hendrix's sons. Oliver and Bill (on tractor), stacking hay on a farm around Leon, Iowa in 1939." },
new Photo { PhotoId = 8, FileName = "EH-008.jpg", OccasionId = "EH", Description = "Oliver." },
new Photo { PhotoId = 9, FileName = "HR67-000.jpg", OccasionId = "HR67", Description = "written by Stella (Wood) Hendrix" },
new Photo { PhotoId = 11, FileName = "HR67-001.jpg", OccasionId = "HR67", Description = "Back row: Michael, Francis and Cleveland; middle row: their mother Orphia (Davis) Deevers and Debora; and in front: Russell." },
new Photo { PhotoId = 12, FileName = "HR67-002.jpg", OccasionId = "HR67", Description = "Brothers, Ed and Bill Hendrix" },
new Photo { PhotoId = 13, FileName = "HR67-003.jpg", OccasionId = "HR67", Description = "Judy (Hendrix) Bertelson" },
new Photo { PhotoId = 14, FileName = "HR67-004.jpg", OccasionId = "HR67", Description = "Jim Hendrix" },
new Photo { PhotoId = 15, FileName = "HR67-005.jpg", OccasionId = "HR67", Description = "Larry Hendrix" },
new Photo { PhotoId = 16, FileName = "HR67-006.jpg", OccasionId = "HR67", Description = "Pat Hendrix, Diane Hendrix and Linda (Hendrix) Burson holding Michelle Hendrix" },
new Photo { PhotoId = 17, FileName = "HR67-007.jpg", OccasionId = "HR67", Description = "Back: Janice (Mrs Ed) Hendrix, Mary Ann (Mrs Jim) Hendrix and Joy Reed; Front: Tony Hendrix and Diane Hendrix" },
new Photo { PhotoId = 18, FileName = "HR67-008.jpg", OccasionId = "HR67", Description = "Eddie (Hendrix) Stuart and Shirley Hendrix" },
new Photo { PhotoId = 19, FileName = "HR67-009.jpg", OccasionId = "HR67", Description = "Janice (Hendrix) Bartholomew and Larry Hendrix, sister and brother." },
new Photo { PhotoId = 20, FileName = "HR67-010.jpg", OccasionId = "HR67", Description = "Kay (Hendrix) Reed and daughter Joy Reed" },
new Photo { PhotoId = 21, FileName = "HR67-011.jpg", OccasionId = "HR67", Description = "Reta (Mrs Larry) Hendrix and daughter Michelle" },
new Photo { PhotoId = 22, FileName = "HR68-001.jpg", OccasionId = "HR68", Description = "written by Stella Wood Hendrix" },
new Photo { PhotoId = 23, FileName = "HR68-002.jpg", OccasionId = "HR68", Description = "Ed and Orphia Deevers" },
new Photo { PhotoId = 24, FileName = "HR68-003.jpg", OccasionId = "HR68", Description = "Eddie (Hendrix) Stuart, Gayle Hendrix, Joyce and daughter Debbie Hendrix" },
new Photo { PhotoId = 25, FileName = "HR68-004.jpg", OccasionId = "HR68", Description = "On the front bench are Norman and Linda (Hendrix) Burson and children, Doug and Chari. Beside Linda is Marcella (Mrs Art) Wood. Back row ?, Janice (Mrs Ed) Hendrix and ?" },
new Photo { PhotoId = 26, FileName = "HR68-005.jpg", OccasionId = "HR68", Description = "Ed and Orphia Deevers and their four sons, Cleveland, Francis, Michael and Russell (not necessarily in that order)" },
new Photo { PhotoId = 27, FileName = "HR68-006.jpg", OccasionId = "HR68", Description = "Elizabeth, Dianna and their parents, LaDonna and Floyd Green." },
new Photo { PhotoId = 28, FileName = "HR68-007.jpg", OccasionId = "HR68", Description = "Dick and Gayle Hendrix" },
new Photo { PhotoId = 29, FileName = "HR68-008.jpg", OccasionId = "HR68", Description = "Janice (Ed Hendrix), Diane and her mother Mary Ann (Jim Hendrix)" },
new Photo { PhotoId = 30, FileName = "HR68-009.jpg", OccasionId = "HR68", Description = "In back, left Janice (Mrs Ed) Hendrix, Joyce (Mrs Ron) Hendrix and Mary Ann (Mrs Jim) Hendrix. In front, Art Wood, Stella (Wood), (Mrs Bill) Hendrix's brother, and Jim Hendrix." },
new Photo { PhotoId = 31, FileName = "HR68-010.jpg", OccasionId = "HR68", Description = "Jim (Eddie Hendrix) Stuart with sons Jimmy and Mark" },
new Photo { PhotoId = 32, FileName = "HR76-001.jpg", OccasionId = "HR76", Description = "written by Stella (Wood) Hendrix" },
new Photo { PhotoId = 33, FileName = "HR76-002.jpg", OccasionId = "HR76", Description = "Oliver Hendrix" },
new Photo { PhotoId = 34, FileName = "HR76-003.jpg", OccasionId = "HR76", Description = "Larry Hendrix and his dad, Bill" },
new Photo { PhotoId = 35, FileName = "HR76-004.jpg", OccasionId = "HR76", Description = "Tom Bertelson (Judy Hendrix) and Jack Reed (Kay Hendrix)" },
new Photo { PhotoId = 36, FileName = "HR76-005.jpg", OccasionId = "HR76", Description = "Gayle Marsh (girlfriend of Dick Hendrix) in back, Eddie (Hendrix) Stuart and Shirley Hendrix" },
new Photo { PhotoId = 37, FileName = "HR76-006.jpg", OccasionId = "HR76", Description = "Ed Hendrix" },
new Photo { PhotoId = 38, FileName = "HR76-007.jpg", OccasionId = "HR76", Description = "Eddie (Hendrix) Stuart" },
new Photo { PhotoId = 39, FileName = "HR76-008.jpg", OccasionId = "HR76", Description = "Gary Hendrix" },
new Photo { PhotoId = 40, FileName = "HR76-009.jpg", OccasionId = "HR76", Description = "Donnie Hendrix with Chari (Burson) McEvoy looking on" },
new Photo { PhotoId = 41, FileName = "HR76-010.jpg", OccasionId = "HR76", Description = "Ron and Pat (Hendrix) Lease" },
new Photo { PhotoId = 42, FileName = "HR76-011.jpg", OccasionId = "HR76", Description = "Ronnie Hendrix" },
new Photo { PhotoId = 43, FileName = "HR76-012.jpg", OccasionId = "HR76", Description = "Bill Hendrix" },
new Photo { PhotoId = 44, FileName = "HR77-001.jpg", OccasionId = "HR77", Description = "captured from Stella (Wood) Hendrix's photo albumn" },
new Photo { PhotoId = 45, FileName = "HR77-002.jpg", OccasionId = "HR77", Description = "Donny and Ronny Hendrix, Gary Hendrix in the green shirt, Harold Hendrix leaning on the car and Chet Hendrix" },
new Photo { PhotoId = 46, FileName = "HR77-003.jpg", OccasionId = "HR77", Description = "Janice (Hendrix) Bartholomew on right" },
new Photo { PhotoId = 47, FileName = "HR77-004.jpg", OccasionId = "HR77", Description = "Shirley (Hendrix) Morton in background, Chet Hendrix and Pat (Hendrix) Lease" },
new Photo { PhotoId = 48, FileName = "HR77-005.jpg", OccasionId = "HR77", Description = "Greg Hendrix, Michelle Hendrix, Chari Burson, Tony Hendrix and in front Brad Bartholomew" },
new Photo { PhotoId = 49, FileName = "HR77-006.jpg", OccasionId = "HR77", Description = "Chari Burson on right" },
new Photo { PhotoId = 50, FileName = "HR77-007.jpg", OccasionId = "HR77", Description = "Greg, Michelle, Chari, Tony and Brad" },
new Photo { PhotoId = 51, FileName = "HR78-001.jpg", OccasionId = "HR78", Description = "written by Stella (Wood) Hendrix" },
new Photo { PhotoId = 52, FileName = "HR78-002.jpg", OccasionId = "HR78", Description = "Ed and Janice's family" },
new Photo { PhotoId = 53, FileName = "HR78-003.jpg", OccasionId = "HR78", Description = "Betty (Mrs Oliver) Hendrix, left front!" },
new Photo { PhotoId = 54, FileName = "HR78-004.jpg", OccasionId = "HR78", Description = "Mike and his Dad, Larry Hendrix" },
new Photo { PhotoId = 55, FileName = "HR78-005.jpg", OccasionId = "HR78", Description = "Ralph Bethards and his Step-Mother, Jessie (Hendrix) Bethards" },
new Photo { PhotoId = 56, FileName = "HR78-006.jpg", OccasionId = "HR78", Description = "In front, Mildred (Mrs Chet) Hendrix, Janice (Hendrix) (Mrs Fred) James, Mike (Kellie) Hendrix, ?, and Donnie (Marla) Hendrix" },
new Photo { PhotoId = 57, FileName = "HR78-007.jpg", OccasionId = "HR78", Description = "Larry and Reta Hendrix and brother Gary Hendrix" },
new Photo { PhotoId = 58, FileName = "HR78-008.jpg", OccasionId = "HR78", Description = "Oliver Hendrix and Donnie Hendrix" },
new Photo { PhotoId = 59, FileName = "HR78-009.jpg", OccasionId = "HR78", Description = "Betty (Mrs Oliver) Hendrix" },
new Photo { PhotoId = 60, FileName = "HR78-010.jpg", OccasionId = "HR78", Description = "Mildred (Mrs Chet) Hendrix, not sure who the little boy is, and Betty (Mrs Oliver) Hendrix, sister-in-laws! Little boy could be Darin Donnie and Marla Hendrix's son?" },
new Photo { PhotoId = 61, FileName = "HR78-011.jpg", OccasionId = "HR78", Description = "written by Stella (Wood) Hendrix" },
new Photo { PhotoId = 62, FileName = "HR78-012.jpg", OccasionId = "HR78", Description = "Mike Hendrix on left" },
new Photo { PhotoId = 63, FileName = "HR78-013.jpg", OccasionId = "HR78", Description = "Harold Hendrix" },
new Photo { PhotoId = 64, FileName = "HR78-015.jpg", OccasionId = "HR78", Description = "Behind ?, Mildred (Mrs Chet) Hendrix, Janice (Mrs Ed) Hendrix, front Kay (Mrs Jack) Reed and Jim Stuart Jr." },
new Photo { PhotoId = 65, FileName = "HR78-016.jpg", OccasionId = "HR78", Description = "Hendrix cousins, Harold on left (Mary), and Donnie (Marla)" },
new Photo { PhotoId = 66, FileName = "HR78-017.jpg", OccasionId = "HR78", Description = "Marla (Mrs Donnie) Hendrix" },
new Photo { PhotoId = 67, FileName = "HR78-018.jpg", OccasionId = "HR78", Description = "Pat (Hendrix) Lease, Kay Hendrix, Jim Stuart Jr, Michele Stewart, Joyce Hendrix, Ron Hendrix, Tom Bertelson" },
new Photo { PhotoId = 68, FileName = "HR78-019.jpg", OccasionId = "HR78", Description = "Hendrix brothers, Ed on left (Janice) and Bill (Stella)" },
new Photo { PhotoId = 69, FileName = "HR81-001.jpg", OccasionId = "HR81", Description = "Kathy and Dennis Hendrix, with family:  Tacy, Tonya and Troy" },
new Photo { PhotoId = 70, FileName = "HR81-002.jpg", OccasionId = "HR81", Description = "These are four of the Hendrix brothers; Chet, Oliver, Ed and Bill. Their brother Jim could not be there." },
new Photo { PhotoId = 71, FileName = "HR81-003.jpg", OccasionId = "HR81", Description = "Mary (Mrs Harold) Hendrix with son David" },
new Photo { PhotoId = 72, FileName = "HR81-004.jpg", OccasionId = "HR81", Description = "These are all Hendrix cousins! On the left of table are Donnie, Gary and Denny and right side are Harold and Dick!" },
new Photo { PhotoId = 73, FileName = "HR81-005.jpg", OccasionId = "HR81", Description = "Larry Hendrix, then-wife Rita, and daughter Michelle, with Chet Hendrix" },
new Photo { PhotoId = 74, FileName = "HR81-007.jpg", OccasionId = "HR81", Description = "Eddie (Hendrix) (Mrs Jim) Stuart and granddaughter Nicole Stuart" },
new Photo { PhotoId = 75, FileName = "HR81-008.jpg", OccasionId = "HR81", Description = "Hendrix cousins, Gary Hendrix and Kay (Hendrix) (Mrs Jack) Reed!" },
new Photo { PhotoId = 76, FileName = "HR81-009.jpg", OccasionId = "HR81", Description = "Pat (Hendrix) (Mrs Ron) Lease" },
new Photo { PhotoId = 77, FileName = "HR81-010.jpg", OccasionId = "HR81", Description = "Shirley (Hendrix) and Bob Morton." },
new Photo { PhotoId = 78, FileName = "HR81-012.jpg", OccasionId = "HR81", Description = "Ed and Janice Hendrix family - Shirley, Kay, Eddie, Ed, Janice, Dick, Judy and Pat !" },
new Photo { PhotoId = 79, FileName = "HR82-001.jpg", OccasionId = "HR82", Description = "Ed (Janice) Hendrix, Fred/Sonny (Janice) James, Ralph Bethards, Bill (Stella) Hendrix and Chet (Mildred) Hendrix" },
new Photo { PhotoId = 80, FileName = "HR82-002.jpg", OccasionId = "HR82", Description = "Jessie (Hendrix) (Mrs Otto) Bethards and Betty (Mrs Oliver) Hendrix" },
new Photo { PhotoId = 81, FileName = "HR82-003.jpg", OccasionId = "HR82", Description = "Randy and Paula Hendrix and their children Jason and Rene" },
new Photo { PhotoId = 82, FileName = "HR84-001.jpg", OccasionId = "HR84", Description = "Harold Hendrix and Dick Hendrix, cousins" },
new Photo { PhotoId = 83, FileName = "HR84-002.jpg", OccasionId = "HR84", Description = "Sonny, Janice and their son Brad James" },
new Photo { PhotoId = 84, FileName = "HR84-003.jpg", OccasionId = "HR84", Description = "Don and Marla Hendrix and children, Darci, Deena and Darin" },
new Photo { PhotoId = 85, FileName = "HR84-004.jpg", OccasionId = "HR84", Description = "Marla (Mrs Don) and her mother-in-law Mildred (Mrs Chet) Hendrix" },
new Photo { PhotoId = 86, FileName = "HR84-005.jpg", OccasionId = "HR84", Description = "Gary Hendrix" },
new Photo { PhotoId = 87, FileName = "HR84-006.jpg", OccasionId = "HR84", Description = "Pat (Hendrix) and Ron Lease" },
new Photo { PhotoId = 88, FileName = "HR84-007.jpg", OccasionId = "HR84", Description = "David Hendrix" },
new Photo { PhotoId = 89, FileName = "HR84-009.jpg", OccasionId = "HR84", Description = "Mildred and Chet Hendrix and granddaughter Darci" },
new Photo { PhotoId = 90, FileName = "HR85-001.jpg", OccasionId = "HR85", Description = "Joyce and Ron Hendrix" },
new Photo { PhotoId = 91, FileName = "HR85-002.jpg", OccasionId = "HR85", Description = "Joyce (Mrs Ron) Hendrix and Mildred (Mrs Chet) Hendrix" },
new Photo { PhotoId = 92, FileName = "HR85-004.jpg", OccasionId = "HR85", Description = "Linda (Hendrix) Burson" },
new Photo { PhotoId = 93, FileName = "HR85-005.jpg", OccasionId = "HR85", Description = "Harold Hendrix, Janice (Hendrix) James in background and Oliver and Betty Hendrix seated!" },
new Photo { PhotoId = 94, FileName = "HR85-006.jpg", OccasionId = "HR85", Description = "Jim and Mary Ann Hendrix!" },
new Photo { PhotoId = 95, FileName = "HR85-007.jpg", OccasionId = "HR85", Description = "Harold Hendrix, Brad James and Oliver Hendrix seated!" },
new Photo { PhotoId = 96, FileName = "HR85-008.jpg", OccasionId = "HR85", Description = "Brad James in background, Mary and Harold Hendrix, Oliver Hendrix and Jessie (Hendrix) Bethards in front!" },
new Photo { PhotoId = 97, FileName = "HR85-009.jpg", OccasionId = "HR85", Description = "Baby Andrew born June 30th to Randy and Paula Hendrix" },
new Photo { PhotoId = 98, FileName = "HR85-010.jpg", OccasionId = "HR85", Description = "Rick and Rachel Hendrix" },
new Photo { PhotoId = 99, FileName = "HR85-011.jpg", OccasionId = "HR85", Description = "David and Harold Hendrix, Larry Hendrix, Janice (Hendrix) James, Linda (Hendrix) Burson, Gary Hendrix" },
new Photo { PhotoId = 100, FileName = "HR85-013.jpg", OccasionId = "HR85", Description = "Bill Hendrix" },
new Photo { PhotoId = 101, FileName = "HR85-015.jpg", OccasionId = "HR85", Description = "back, Jim, Chet, Bill, and Ed; front, Oliver, all Hendrix brother and their sister, Jessie (Hendrix) Bethards" },
new Photo { PhotoId = 102, FileName = "HR85-016.jpg", OccasionId = "HR85", Description = "Jason Morton" },
new Photo { PhotoId = 103, FileName = "HR85-017.jpg", OccasionId = "HR85", Description = "Don Hendrix and Ed Hendrix" },
new Photo { PhotoId = 104, FileName = "HR85-018.jpg", OccasionId = "HR85", Description = "Jim and Mary Ann Hendrix and Jessie (Hendrix) Bethards in front!" },
new Photo { PhotoId = 105, FileName = "HR85-020.jpg", OccasionId = "HR85", Description = "Mary (Mrs Harold) Hendrix and Shirley (Hendrix) Morton" },
new Photo { PhotoId = 106, FileName = "HR85-021.jpg", OccasionId = "HR85", Description = "Harry and Sandra (Hendrix) Kennedy" },
new Photo { PhotoId = 107, FileName = "HR85-022.jpg", OccasionId = "HR85", Description = "from left - Don Hendrix, Jim Hendrix, Linda (Hendrix) Burson and Larry Hendrix" },
new Photo { PhotoId = 108, FileName = "HR85-024.jpg", OccasionId = "HR85", Description = "Jessie (Hendrix) Bethards and Darci Hendrix" },
new Photo { PhotoId = 109, FileName = "HR86-001.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 110, FileName = "HR86-002.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 111, FileName = "HR86-003.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 112, FileName = "HR86-004.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 113, FileName = "HR86-005.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 114, FileName = "HR86-006.jpg", OccasionId = "HR86", Description = "Don Hendrix in back, son Darin, wife Marla, father Chet, mother Mildred and daughter's Darci and Deena" },
new Photo { PhotoId = 115, FileName = "HR86-007.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 116, FileName = "HR86-008.jpg", OccasionId = "HR86", Description = "back: Brad James, Gary Hendrix, Janice and Sonny James; front: Bill and Stella Hendrix, Harold Hendrix with David, Larry Hendrix with Erika and Jeremy" },
new Photo { PhotoId = 117, FileName = "HR86-009.jpg", OccasionId = "HR86", Description = "Jessie (Hendrix) Bethards" },
new Photo { PhotoId = 118, FileName = "HR86-010.jpg", OccasionId = "HR86", Description = "Uncle Jim and Aunt Mary Ann Hendrix" },
new Photo { PhotoId = 119, FileName = "HR86-011.jpg", OccasionId = "HR86", Description = "Aunt Mary Ann (Jim) Hendrix (back) and Janice James" },
new Photo { PhotoId = 120, FileName = "HR86-012.jpg", OccasionId = "HR86", Description = "Michelle (Hendrix) and Lonnie Dwyer" },
new Photo { PhotoId = 121, FileName = "HR86-013.jpg", OccasionId = "HR86", Description = "Brad, Sonny and Janice James" },
new Photo { PhotoId = 122, FileName = "HR86-014.jpg", OccasionId = "HR86", Description = "Harold and David Hendrix" },
new Photo { PhotoId = 123, FileName = "HR86-015.jpg", OccasionId = "HR86", Description = "Aunt Betty and Uncle Oliver Hendrix" },
new Photo { PhotoId = 124, FileName = "HR86-016.jpg", OccasionId = "HR86", Description = "Brothers, Chet, Oliver and Ed Hendrix" },
new Photo { PhotoId = 125, FileName = "HR86-017.jpg", OccasionId = "HR86", Description = "Ed and Janice Hendrix" },
new Photo { PhotoId = 126, FileName = "HR86-018.jpg", OccasionId = "HR86", Description = "Kathy and Dennis Hendrix and children Troy, Tacy and Tonya" },
new Photo { PhotoId = 127, FileName = "HR86-019.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 128, FileName = "HR86-020.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 129, FileName = "HR86-021.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 130, FileName = "HR86-022.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 131, FileName = "HR86-023.jpg", OccasionId = "HR86", Description = "Oliver, Jessie(Hendrix) Bethards, Jim, Bill and Chet. All Hendrix brothers and sister" },
new Photo { PhotoId = 132, FileName = "HR86-024.jpg", OccasionId = "HR86", Description = "Oliver, Jessie (Bethards) Hendrix, Jim, Bill and Chet. All Hendrix brothers and sister!" },
new Photo { PhotoId = 133, FileName = "HR86-025.jpg", OccasionId = "HR86", Description = "Janice (Hendrix) and Sonny James" },
new Photo { PhotoId = 134, FileName = "HR86-026.jpg", OccasionId = "HR86", Description = "Larry, Kellie, Mike, Jeremy and Erica Hendrix" },
new Photo { PhotoId = 135, FileName = "HR86-027.jpg", OccasionId = "HR86", Description = "Stella (Wood) and Bill Hendrix" },
new Photo { PhotoId = 136, FileName = "HR86-028.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 137, FileName = "HR86-029.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 138, FileName = "HR86-030.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 139, FileName = "HR86-031.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 140, FileName = "HR86-032.jpg", OccasionId = "HR86", Description = "Mike, Jeremy and Erica Hendrix" },
new Photo { PhotoId = 141, FileName = "HR86-033.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 142, FileName = "HR86-034.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 143, FileName = "HR86-035.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 144, FileName = "HR86-036.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 145, FileName = "HR86-037.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 146, FileName = "HR86-038.jpg", OccasionId = "HR86", Description = "no description" },
new Photo { PhotoId = 147, FileName = "HR87-001.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 148, FileName = "HR87-002.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 149, FileName = "HR87-003.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 150, FileName = "HR87-004.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 151, FileName = "HR87-005.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 152, FileName = "HR87-006.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 153, FileName = "HR87-007.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 154, FileName = "HR87-008.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 155, FileName = "HR87-009.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 156, FileName = "HR87-010.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 157, FileName = "HR87-011.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 158, FileName = "HR87-012.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 159, FileName = "HR87-013.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 160, FileName = "HR87-014.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 161, FileName = "HR87-015.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 162, FileName = "HR87-016.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 163, FileName = "HR87-017.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 164, FileName = "HR87-018.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 165, FileName = "HR87-019.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 166, FileName = "HR87-020.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 167, FileName = "HR87-021.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 168, FileName = "HR87-022.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 169, FileName = "HR87-023.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 170, FileName = "HR87-024.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 171, FileName = "HR87-025.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 172, FileName = "HR87-026.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 173, FileName = "HR87-027.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 174, FileName = "HR87-028.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 175, FileName = "HR87-029.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 176, FileName = "HR87-030.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 177, FileName = "HR87-031.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 178, FileName = "HR87-032.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 179, FileName = "HR87-033.jpg", OccasionId = "HR87", Description = "no description" },
new Photo { PhotoId = 180, FileName = "HR88-001.jpg", OccasionId = "HR88", Description = "no description" },
new Photo { PhotoId = 181, FileName = "HR88-002.jpg", OccasionId = "HR88", Description = "no description" },
new Photo { PhotoId = 182, FileName = "HR88-003.jpg", OccasionId = "HR88", Description = "no description" },
new Photo { PhotoId = 183, FileName = "HR88-004.jpg", OccasionId = "HR88", Description = "no description" },
new Photo { PhotoId = 184, FileName = "HR88-005.jpg", OccasionId = "HR88", Description = "no description" },
new Photo { PhotoId = 185, FileName = "HR88-006.jpg", OccasionId = "HR88", Description = "no description" },
new Photo { PhotoId = 186, FileName = "HR88-007.jpg", OccasionId = "HR88", Description = "no description" },
new Photo { PhotoId = 187, FileName = "HR88-008.jpg", OccasionId = "HR88", Description = "no description" },
new Photo { PhotoId = 188, FileName = "HR88-009.jpg", OccasionId = "HR88", Description = "no description" },
new Photo { PhotoId = 189, FileName = "HR88-010.jpg", OccasionId = "HR88", Description = "no description" },
new Photo { PhotoId = 190, FileName = "HR88-011.jpg", OccasionId = "HR88", Description = "no description" },
new Photo { PhotoId = 191, FileName = "HR88-012.jpg", OccasionId = "HR88", Description = "no description" },
new Photo { PhotoId = 192, FileName = "HR89-001.jpg", OccasionId = "HR89", Description = "no description" },
new Photo { PhotoId = 193, FileName = "HR89-002.jpg", OccasionId = "HR89", Description = "no description" },
new Photo { PhotoId = 194, FileName = "HR89-003.jpg", OccasionId = "HR89", Description = "no description" },
new Photo { PhotoId = 195, FileName = "HR89-004.jpg", OccasionId = "HR89", Description = "no description" },
new Photo { PhotoId = 196, FileName = "HR89-005.jpg", OccasionId = "HR89", Description = "no description" },
new Photo { PhotoId = 197, FileName = "HR89-006.jpg", OccasionId = "HR89", Description = "no description" },
new Photo { PhotoId = 198, FileName = "HR89-007.jpg", OccasionId = "HR89", Description = "no description" },
new Photo { PhotoId = 199, FileName = "HR89-008.jpg", OccasionId = "HR89", Description = "no description" },
new Photo { PhotoId = 200, FileName = "HR89-009.jpg", OccasionId = "HR89", Description = "no description" },
new Photo { PhotoId = 201, FileName = "HR89-010.jpg", OccasionId = "HR89", Description = "no description" },
new Photo { PhotoId = 202, FileName = "HR89-011.jpg", OccasionId = "HR89", Description = "no description" },
new Photo { PhotoId = 203, FileName = "HR89-012.jpg", OccasionId = "HR89", Description = "no description" },
new Photo { PhotoId = 204, FileName = "HR89-013.jpg", OccasionId = "HR89", Description = "no description" },
new Photo { PhotoId = 205, FileName = "HR89-014.jpg", OccasionId = "HR89", Description = "no description" },
new Photo { PhotoId = 206, FileName = "HR89-015.jpg", OccasionId = "HR89", Description = "no description" },
new Photo { PhotoId = 207, FileName = "HR90-001.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 208, FileName = "HR90-002.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 209, FileName = "HR90-003.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 210, FileName = "HR90-004.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 211, FileName = "HR90-005.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 212, FileName = "HR90-006.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 213, FileName = "HR90-007.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 214, FileName = "HR90-008.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 215, FileName = "HR90-009.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 216, FileName = "HR90-010.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 217, FileName = "HR90-011.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 218, FileName = "HR90-012.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 219, FileName = "HR90-013.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 220, FileName = "HR90-014.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 221, FileName = "HR90-015.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 222, FileName = "HR90-016.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 223, FileName = "HR90-017.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 224, FileName = "HR90-018.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 225, FileName = "HR90-019.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 226, FileName = "HR90-020.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 227, FileName = "HR90-021.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 228, FileName = "HR90-022.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 229, FileName = "HR90-023.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 230, FileName = "HR90-024.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 231, FileName = "HR90-025.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 232, FileName = "HR90-026.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 233, FileName = "HR90-027.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 234, FileName = "HR90-028.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 235, FileName = "HR90-029.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 236, FileName = "HR90-030.jpg", OccasionId = "HR90", Description = "no description" },
new Photo { PhotoId = 237, FileName = "HR90-031.jpg", OccasionId = "HR90", Description = "no description" }
                );

            modelBuilder.Entity<Occasion>().HasData(
                new Occasion
                {
                    OccasionId = "EH",
                    OccasionName = "Early Hendrix Photos",
                    OccasionDescription = "Photos of Elisha and his children."
                },
                new Occasion
                {
                    OccasionId = "HR67",
                    OccasionName = "Hendrix Reunion, 1967",
                    OccasionDescription = "The very first Hendrix Reunion."
                },
                new Occasion
                {
                    OccasionId = "00",
                    OccasionName = "All",
                    OccasionDescription = "All Photos"
                },
                new Occasion
                {
                    OccasionId = "HR68",
                    OccasionName = "Hendrix Reunion, 1968",
                    OccasionDescription = ""
                },
                new Occasion
                {
                    OccasionId = "HR76",
                    OccasionName = "Hendrix Reunion, 1976",
                    OccasionDescription = ""
                },
                new Occasion
                {
                    OccasionId = "HR77",
                    OccasionName = "Hendrix Reunion, 1977",
                    OccasionDescription = ""
                },
                new Occasion
                {
                    OccasionId = "HR78",
                    OccasionName = "Hendrix Reunion, 1978",
                    OccasionDescription = ""
                },
                new Occasion
                {
                    OccasionId = "HR81",
                    OccasionName = "Hendrix Reunion, 1981",
                    OccasionDescription = ""
                },
                new Occasion
                {
                    OccasionId = "HR82",
                    OccasionName = "Hendrix Reunion, 1982",
                    OccasionDescription = ""
                },
                new Occasion
                {
                    OccasionId = "HR84",
                    OccasionName = "Hendrix Reunion, 1984",
                    OccasionDescription = ""
                },
                new Occasion
                {
                    OccasionId = "HR85",
                    OccasionName = "Hendrix Reunion, 1985",
                    OccasionDescription = ""
                },
                new Occasion
                {
                    OccasionId = "HR86",
                    OccasionName = "Hendrix Reunion, 1986",
                    OccasionDescription = ""
                },
                new Occasion
                {
                    OccasionId = "HR87",
                    OccasionName = "Hendrix Reunion, 1987",
                    OccasionDescription = ""
                },
                new Occasion
                {
                    OccasionId = "HR88",
                    OccasionName = "Hendrix Reunion, 1988",
                    OccasionDescription = ""
                },
                new Occasion
                {
                    OccasionId = "HR89",
                    OccasionName = "Hendrix Reunion, 1989",
                    OccasionDescription = ""
                },
                new Occasion
                {
                    OccasionId = "HR90",
                    OccasionName = "Hendrix Reunion, 1990",
                    OccasionDescription = ""
                }
                );

            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    CommentId = 1,
                    CommentPhotoId = 9,
                    //CommentMemberId = 1,
                    CommentActual = "Grandma Stella always had great penmanship!"
                }
                );

            //modelBuilder.Entity<User>().HasData(
            //    new User
            //    {
            //        MemberId = 1,
            //        MemberName = "Tony Hendrix-Hill"
            //    }
            //    );
        }
    }
}
